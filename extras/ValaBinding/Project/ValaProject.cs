//
// ValaProject.cs: Vala Project
//
// Authors:
//  Levi Bard <taktaktaktaktaktaktaktaktaktak@gmail.com> 
//
// Copyright (C) 2008 Levi Bard
// Based on CBinding by Marcos David Marin Amador <MarcosMarin@gmail.com>
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
//


using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;

using Mono.Addins;

using MonoDevelop.Core;
using MonoDevelop.Core.Gui;
using MonoDevelop.Core.Execution;
using MonoDevelop.Core.ProgressMonitoring;
using MonoDevelop.Projects;
using MonoDevelop.Projects.Serialization;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Deployment;
using MonoDevelop.Deployment.Linux;

using MonoDevelop.ValaBinding.Parser;

namespace MonoDevelop.ValaBinding
{
	public enum ValaProjectCommands {
		AddPackage,
		UpdateClassPad
	}
	
	[DataInclude(typeof(ValaProjectConfiguration))]
	public class ValaProject : Project, IDeployable
	{
		[ItemProperty ("compiler", ValueType = typeof(ValaCompiler))]
		private ICompiler compiler_manager;
		
		private ProjectPackageCollection packages = new ProjectPackageCollection ();
		
		public event ProjectPackageEventHandler PackageAddedToProject;
		public event ProjectPackageEventHandler PackageRemovedFromProject;
		
		private void Init ()
		{
			packages.Project = this;
			
			//IdeApp.ProjectOperations.EntryAddedToCombine += OnEntryAddedToCombine;
		}
		
		public ValaProject ()
		{
			Init ();
		}
		
		public ValaProject (ProjectCreateInformation info,
						 XmlElement projectOptions, string language)
		{
			Init ();
			string binPath = ".";
			
			if (info != null) {
				Name = info.ProjectName;
				binPath = info.BinPath;
			}
			
			Compiler = null;
			
			ValaProjectConfiguration configuration =
				(ValaProjectConfiguration)CreateConfiguration ("Debug");
			
			((ValaCompilationParameters)configuration.CompilationParameters).DefineSymbols = "DEBUG MONODEVELOP";		
				
			Configurations.Add (configuration);
			
			configuration =
				(ValaProjectConfiguration)CreateConfiguration ("Release");
				
			configuration.DebugMode = false;
			((ValaCompilationParameters)configuration.CompilationParameters).OptimizationLevel = 3;
			((ValaCompilationParameters)configuration.CompilationParameters).DefineSymbols = "MONODEVELOP";
			Configurations.Add (configuration);
			
			foreach (ValaProjectConfiguration c in Configurations) {
				c.OutputDirectory = Path.Combine (binPath, c.Name);
				c.SourceDirectory = info.ProjectBasePath;
				c.Output = Name;
				ValaCompilationParameters parameters = c.CompilationParameters as ValaCompilationParameters;
				
				if (projectOptions != null) {
					if (projectOptions.Attributes["Target"] != null) {
						c.CompileTarget = (ValaBinding.CompileTarget)Enum.Parse (
							typeof(ValaBinding.CompileTarget),
							projectOptions.Attributes["Target"].InnerText);
					}
					if (projectOptions.Attributes["PauseConsoleOutput"] != null) {
						c.PauseConsoleOutput = bool.Parse (
							projectOptions.Attributes["PauseConsoleOutput"].InnerText);
					}
					if (projectOptions.Attributes["CompilerArgs"].InnerText != null) {
						if (parameters != null) {
							parameters.ExtraCompilerArguments = projectOptions.Attributes["CompilerArgs"].InnerText;
						}
					}
				}
			}			
		}
		
		public override string ProjectType {
			get { return "Vala"; }
		}
		
		public override string[] SupportedLanguages {
			get { return new string[] { "Vala" }; }
		}
		
		public override bool IsCompileable (string fileName)
		{
			string ext = Path.GetExtension(fileName);
			return (ext.Equals(".vala", StringComparison.CurrentCultureIgnoreCase) ||
				ext.Equals(".vapi", StringComparison.CurrentCultureIgnoreCase));
		}
		
		public List<ValaProject> DependedOnProjects ()
		{
			List<string> project_names = new List<string> ();
			List<ValaProject> projects = new List<ValaProject> ();
			
			foreach (ProjectPackage p in Packages) {
				if (p.IsProject && p.Name != Name) {
					project_names.Add (p.Name);
				}
			}
			
			foreach (SolutionItem e in ParentFolder.Items) {
				if (e is ValaProject && project_names.Contains (e.Name)) {
					projects.Add ((ValaProject)e);
				}
			}
			
			return projects;
		}
		
		/// <summary>
		/// Ths pkg-config package is for internal MonoDevelop use only, it is not deployed.
		/// </summary>
		public void WriteMDPkgPackage (string configuration)
		{
			string pkgfile = Path.Combine (BaseDirectory, Name + ".md.pc");
			
			ValaProjectConfiguration config = (ValaProjectConfiguration)GetConfiguration(configuration);
			
			using (StreamWriter writer = new StreamWriter (pkgfile)) {
				writer.WriteLine ("Name: {0}", Name);
				writer.WriteLine ("Description: {0}", Description);
				writer.WriteLine ("Version: {0}", Version);
				writer.WriteLine ("Libs: -L{0} -l{1}", config.OutputDirectory, config.Output);
//				writer.WriteLine ("Cflags: -I{0}", BaseDirectory);
			}
			
			// If this project compiles into a shared object we need to
			// export the output path to the LD_LIBRARY_PATH
			string literal = "LD_LIBRARY_PATH";
			string ld_library_path = Environment.GetEnvironmentVariable (literal);
			
			if (string.IsNullOrEmpty (ld_library_path)) {
				Environment.SetEnvironmentVariable (literal, config.OutputDirectory);
			} else if (!ld_library_path.Contains (config.OutputDirectory)) {
				ld_library_path = string.Format ("{0}:{1}", config.OutputDirectory, ld_library_path);
				Environment.SetEnvironmentVariable (literal, ld_library_path);
			}
		}
		
		/// <summary>
		/// This is the pkg-config package that gets deployed.
		/// <returns>The pkg-config package's filename</returns>
		/// </summary>
		private string WriteDeployablePkgPackage (string configuration)
		{
			// FIXME: This should probably be grabed from somewhere.
			string prefix = "/usr/local";
			string pkgfile = Path.Combine (BaseDirectory, Name + ".pc");
			ValaProjectConfiguration config = (ValaProjectConfiguration)GetConfiguration(configuration);
			
			using (StreamWriter writer = new StreamWriter (pkgfile)) {
				writer.WriteLine ("prefix={0}", prefix);
				writer.WriteLine ("exec_prefix=${prefix}");
				writer.WriteLine ("libdir=${exec_prefix}/lib");
				writer.WriteLine ("includedir=${prefix}/include");
				writer.WriteLine ();
				writer.WriteLine ("Name: {0}", Name);
				writer.WriteLine ("Description: {0}", Description);
				writer.WriteLine ("Version: {0}", Version);
				writer.WriteLine ("Requires: {0}", string.Join (" ", Packages.ToStringArray ()));
				// TODO: How should I get this?
				writer.WriteLine ("Conflicts: {0}", string.Empty);
				writer.Write ("Libs: -L${libdir} ");
				writer.WriteLine ("-l{0}", config.Output);
				writer.Write ("Cflags: -I${includedir}/");
				writer.WriteLine ("{0} {1}", Name, Compiler.GetDefineFlags (config));
			}
			
			return pkgfile;
		}
		
		protected override BuildResult DoBuild (IProgressMonitor monitor, string configuration)
		{
			ValaProjectConfiguration pc = (ValaProjectConfiguration)GetConfiguration(configuration);
			pc.SourceDirectory = BaseDirectory;
			
			return compiler_manager.Compile (
				Files, packages,
				pc,
				monitor);
		}
		
		protected override void DoExecute (IProgressMonitor monitor,
										   ExecutionContext context,
		                                   string configuration)
		{
			ValaProjectConfiguration conf = (ValaProjectConfiguration)GetConfiguration(configuration);
			string command = conf.Output;
			string args = conf.CommandLineParameters;
			string dir = Path.GetFullPath (conf.OutputDirectory);
			string platform = "Native";
			bool pause = conf.PauseConsoleOutput;
			IConsole console;
			
			if (conf.CompileTarget != ValaBinding.CompileTarget.Bin) {
				MessageService.ShowMessage ("Compile target is not an executable!");
				return;
			}
			
			monitor.Log.WriteLine ("Running project...");
			
			if (conf.ExternalConsole)
				console = context.ExternalConsoleFactory.CreateConsole (!pause);
			else
				console = context.ConsoleFactory.CreateConsole (!pause);
			
			AggregatedOperationMonitor operationMonitor = new AggregatedOperationMonitor (monitor);
			
			try {
				IExecutionHandler handler = context.ExecutionHandlerFactory.CreateExecutionHandler (platform);
				
				if (handler == null) {
					monitor.ReportError ("Cannot execute \"" + command + "\". The selected execution mode is not supported in the " + platform + " platform.", null);
					return;
				}
				
				IProcessAsyncOperation op = handler.Execute (Path.Combine (dir, command), args, dir, null, console);
				
				operationMonitor.AddOperation (op);
				op.WaitForCompleted ();
				
				monitor.Log.WriteLine ("The operation exited with code: {0}", op.ExitCode);
			} catch (Exception ex) {
				monitor.ReportError ("Cannot execute \"" + command + "\"", ex);
			} finally {			
				operationMonitor.Dispose ();			
				console.Dispose ();
			}
		}
		
		public override string GetOutputFileName (string configuration)
		{
			ValaProjectConfiguration conf = (ValaProjectConfiguration)GetConfiguration(configuration);
			return Path.Combine (conf.OutputDirectory, conf.CompiledOutputName);
		}
		
		public override SolutionItemConfiguration CreateConfiguration (string name)
		{
			ValaProjectConfiguration conf = new ValaProjectConfiguration ();
			
			conf.Name = name;
			conf.CompilationParameters = new ValaCompilationParameters ();
			
			return conf;
		}
		
		public ICompiler Compiler {
			get { return compiler_manager; }
			set {
				if (value != null) {
					compiler_manager = value;
				} else {
					object[] compilers = AddinManager.GetExtensionObjects ("/ValaBinding/Compilers");
					string compiler = PropertyService.Get ("ValaBinding.DefaultValaCompiler", new ValaCompiler().Name);
					
					foreach (ICompiler c in compilers) {
						if (compiler == c.Name) {
							compiler_manager = c;
						}
					}
				}
			}
		}
		
		[Browsable(false)]
		[ItemProperty ("Packages")]
		public ProjectPackageCollection Packages {
			get { return packages; }
			set {
				packages = value;
				packages.Project = this;
			}
		}
		
		protected override void OnFileAddedToProject (ProjectFileEventArgs e)
		{
			base.OnFileAddedToProject (e);
			
			if (!IsCompileable (e.ProjectFile.Name) &&
				e.ProjectFile.BuildAction == BuildAction.Compile) {
				e.ProjectFile.BuildAction = BuildAction.Nothing;
			}
			
			if (e.ProjectFile.BuildAction == BuildAction.Compile)
				TagDatabaseManager.Instance.UpdateFileTags (this, e.ProjectFile.Name);
		}
		
		protected override void OnFileChangedInProject (ProjectFileEventArgs e)
		{
			base.OnFileChangedInProject (e);
			
			TagDatabaseManager.Instance.UpdateFileTags (this, e.ProjectFile.Name);
		}
		
		private static void OnEntryAddedToCombine (object sender, SolutionItemEventArgs e)
		{
			ValaProject p = e.SolutionItem as ValaProject;
			
			if (p == null)
				return;
			
			foreach (ProjectFile f in p.Files)
				TagDatabaseManager.Instance.UpdateFileTags (p, f.Name);
		}
		
		internal void NotifyPackageRemovedFromProject (ProjectPackage package)
		{
			PackageRemovedFromProject (this, new ProjectPackageEventArgs (this, package));
		}
		
		internal void NotifyPackageAddedToProject (ProjectPackage package)
		{
			PackageAddedToProject (this, new ProjectPackageEventArgs (this, package));
		}

		public DeployFileCollection GetDeployFiles (string configuration)
		{
			DeployFileCollection deployFiles = new DeployFileCollection ();
			
			CompileTarget target = ((ValaProjectConfiguration)GetConfiguration(configuration)).CompileTarget;
			
			// Headers and resources
			foreach (ProjectFile f in Files) {
				if (f.BuildAction == BuildAction.FileCopy) {
					string targetDirectory =
						(/*IsHeaderFile (f.Name) ? TargetDirectory.Include :*/ TargetDirectory.ProgramFiles);
					
					deployFiles.Add (new DeployFile (this, f.FilePath, f.RelativePath, targetDirectory));
				}
			}
			
			// Output
			string output = GetOutputFileName (configuration);
			if (!string.IsNullOrEmpty (output)) {
				string targetDirectory = string.Empty;
				
				switch (target) {
				case CompileTarget.Bin:
					targetDirectory = TargetDirectory.ProgramFiles;
					break;
				case CompileTarget.SharedLibrary:
					targetDirectory = TargetDirectory.ProgramFiles;
					break;
				case CompileTarget.StaticLibrary:
					targetDirectory = TargetDirectory.ProgramFiles;
					break;
				}					
				
				deployFiles.Add (new DeployFile (this, output, Path.GetFileName (output), targetDirectory));
			}
			
			// PkgPackage
			if (target != CompileTarget.Bin) {
				string pkgfile = WriteDeployablePkgPackage (configuration);
				deployFiles.Add (new DeployFile (this, Path.Combine (BaseDirectory, pkgfile), pkgfile, LinuxTargetDirectory.PkgConfig));
			}
			
			return deployFiles;
		}
	}
}

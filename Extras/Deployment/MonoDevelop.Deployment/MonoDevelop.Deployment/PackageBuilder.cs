//
// PackageBuilder.cs
//
// Author:
//   Lluis Sanchez Gual
//
// Copyright (C) 2006 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using System.Collections;
using System.Collections.Generic;
using MonoDevelop.Projects.Serialization;
using MonoDevelop.Core;
using MonoDevelop.Core.ProgressMonitoring;
using MonoDevelop.Projects;

namespace MonoDevelop.Deployment
{
	[DataItem (FallbackType=typeof(UnknownPackageBuilder))]
	public class PackageBuilder: IDirectoryResolver
	{
		[ItemProperty ("ChildEntries")]
		[ProjectPathItemProperty ("Entry", Scope=1)]
		List<string> childEntries = new List<string> ();
		
		[ProjectPathItemProperty]
		string rootEntry;
		
		List<CombineEntry> childCombineEntries;
		CombineEntry rootCombineEntry;
		
		public PackageBuilder ()
		{
		}
		
		public virtual string Description {
			get { return GettextCatalog.GetString ("Package"); } 
		}
		
		public virtual string Icon {
			get { return "md-package"; }
		}
		
		public virtual string Validate ()
		{
			return null;
		}
		
		internal void Build (IProgressMonitor monitor)
		{
			monitor.BeginTask ("Package: " + Description, 1);
			DeployContext ctx = null;
			try {
				ctx = CreateDeployContext ();
				OnBuild (monitor, ctx);
			} catch (Exception ex) {
				monitor.ReportError ("Package creation failed", ex);
				monitor.AsyncOperation.Cancel ();
			} finally {
				monitor.EndTask ();
				if (ctx != null)
					ctx.Dispose ();
			}
		}
		
		public virtual bool CanBuild (CombineEntry entry)
		{
			return true;
		}
		
		public virtual void InitializeSettings (CombineEntry entry)
		{
		}
		
		public PackageBuilder Clone ()
		{
			PackageBuilder d = (PackageBuilder) Activator.CreateInstance (GetType());
			d.CopyFrom (this);
			return d;
		}
		
		public virtual void CopyFrom (PackageBuilder other)
		{
			childEntries = new List<string> (other.childEntries);
			rootEntry = other.rootEntry;
			if (other.childCombineEntries != null)
				childCombineEntries = new List<CombineEntry> (other.childCombineEntries);
			else
				childCombineEntries = null;
			rootCombineEntry = other.rootCombineEntry;
		}
		
		protected virtual void OnBuild (IProgressMonitor monitor, DeployContext ctx)
		{
		}
		
		string IDirectoryResolver.GetDirectory (DeployContext ctx, string folderId)
		{
			return OnResolveDirectory (ctx, folderId);
		}
		
		protected virtual string OnResolveDirectory (DeployContext ctx, string folderId)
		{
			return null;
		}
		
		public virtual DeployContext CreateDeployContext ()
		{
			return new DeployContext (this, "Linux", null);
		}
		
		public void SetCombineEntry (CombineEntry rootCombineEntry, CombineEntry[] childEntries)
		{
			this.rootCombineEntry = rootCombineEntry;
			this.rootEntry = rootCombineEntry.FileName;
		
			this.childEntries.Clear ();
			childCombineEntries = new List<CombineEntry> ();
			foreach (CombineEntry e in childEntries) {
				this.childEntries.Add (e.FileName);
				this.childCombineEntries.Add (e);
			}
		
			InitializeSettings (rootCombineEntry);
		}
		
		public CombineEntry RootCombineEntry {
			get {
				if (rootCombineEntry == null && rootEntry != null) {
					rootCombineEntry = Services.ProjectService.ReadCombineEntry (rootEntry, new NullProgressMonitor ());
				}
				return rootCombineEntry; 
			}
		}
		
		public CombineEntry[] GetChildEntries ()
		{
			if (childCombineEntries != null)
				return childCombineEntries.ToArray ();
			
			childCombineEntries = new List<CombineEntry> ();
			foreach (string en in childEntries) {
				CombineEntry re = Services.ProjectService.ReadCombineEntry (en, new NullProgressMonitor ());
				if (re != null && !(re is UnknownCombineEntry))
					childCombineEntries.Add (re);
			}
			return childCombineEntries.ToArray ();
		}
		
		public CombineEntry[] GetAllEntries ()
		{
			List<CombineEntry> list = new List<CombineEntry> ();
			if (RootCombineEntry != null)
				list.Add (RootCombineEntry);
			list.AddRange (GetChildEntries ());
			return list.ToArray ();
		}
	}
}

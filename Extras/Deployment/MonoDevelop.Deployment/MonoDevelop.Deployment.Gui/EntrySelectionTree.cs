
using System;
using System.Collections;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Projects;
using Gtk;

namespace MonoDevelop.Deployment.Gui
{
	public partial class EntrySelectionTree : Gtk.Bin
	{
		TreeStore store;
		Hashtable selectedEntries = new Hashtable ();
		PackageBuilder builder;
		
		public EntrySelectionTree ()
		{
			this.Build();
			
			store = new TreeStore (typeof(string), typeof(string), typeof(object), typeof(bool), typeof(bool));
			tree.Model = store;
			
			tree.HeadersVisible = false;
			TreeViewColumn col = new TreeViewColumn ();
			Gtk.CellRendererToggle ctog = new CellRendererToggle ();
			ctog.Toggled += OnToggled;
			col.PackStart (ctog, false);
			Gtk.CellRendererPixbuf cr = new Gtk.CellRendererPixbuf();
			col.PackStart (cr, false);
			Gtk.CellRendererText crt = new Gtk.CellRendererText();
			col.PackStart (crt, true);
			col.AddAttribute (cr, "stock-id", 0);
			col.AddAttribute (crt, "markup", 1);
			col.AddAttribute (ctog, "active", 3);
			col.AddAttribute (ctog, "visible", 4);
			tree.AppendColumn (col);
		}
		
		public void Fill (PackageBuilder builder, CombineEntry selection)
		{
			store.Clear ();
			
			this.builder = builder;
			if (selection is Combine) {
				foreach (CombineEntry e in ((Combine)selection).GetAllEntries ()) {
					if (builder.CanBuild (e))
						selectedEntries [e] = e;
				}
			}
			else if (selection != null) {
				selectedEntries [selection] = selection;
			}
			
			AddEntry (TreeIter.Zero, IdeApp.ProjectOperations.CurrentOpenCombine);
		}
		
		void AddEntry (TreeIter iter, CombineEntry entry)
		{
			string icon;
			if (entry is Combine)
				icon = MonoDevelop.Core.Gui.Stock.CombineIcon;
			else if (entry is Project)
				icon = IdeApp.Services.Icons.GetImageForProjectType (((Project)entry).ProjectType);
			else
				icon = MonoDevelop.Core.Gui.Stock.SolutionIcon;
			
			bool visible = builder.CanBuild (entry);
			bool selected = selectedEntries.Contains (entry);
			
			if (!(entry is Combine) && !visible)
				return;
			
			if (!iter.Equals (TreeIter.Zero))
				iter = store.AppendValues (iter, icon, entry.Name, entry, selected && visible, visible);
			else
				iter = store.AppendValues (icon, entry.Name, entry, selected && visible, visible);
			
			if (selected)
				tree.ExpandToPath (store.GetPath (iter));
			
			if (entry is Combine) {
				foreach (CombineEntry ce in ((Combine)entry).Entries) {
					if (!(ce is PackagingProject))
						AddEntry (iter, ce);
				}
			}
		}
		
		public CombineEntry GetSelectedEntry ()
		{
			return GetCommonCombineEntry ();
		}
		
		public CombineEntry[] GetSelectedChildren ()
		{
			// The first entry is the root entry
			CombineEntry common = GetCommonCombineEntry ();
			ArrayList list = new ArrayList ();
			foreach (CombineEntry e in selectedEntries.Keys)
				if (e != common)
					list.Add (e);
			return (CombineEntry[]) list.ToArray (typeof(CombineEntry));
		}
		
		void OnToggled (object sender, Gtk.ToggledArgs args)
		{
			TreeIter iter;
			store.GetIterFromString (out iter, args.Path);
			object ob = store.GetValue (iter, 2);
			if (selectedEntries.Contains (ob)) {
				selectedEntries.Remove (ob);
				store.SetValue (iter, 3, false);
				if (ob is Combine) {
					foreach (CombineEntry e in ((Combine)ob).GetAllEntries ())
						selectedEntries.Remove (e);
					UpdateSelectionChecks (TreeIter.Zero);
				}
			} else {
				selectedEntries [ob] = ob;
				store.SetValue (iter, 3, true);
				if (ob is Combine) {
					foreach (CombineEntry e in ((Combine)ob).GetAllEntries ())
						selectedEntries [e] = e;
					UpdateSelectionChecks (TreeIter.Zero);
				}
				SelectCommonCombine ((CombineEntry)ob);
			}
		}
		
		void UpdateSelectionChecks (TreeIter iter)
		{
			if (iter.Equals (TreeIter.Zero)) {
				if (!store.GetIterFirst (out iter))
					return;
			}
			else {
				if (!store.IterChildren (out iter, iter))
					return;
			}
			do {
				bool sel = selectedEntries.Contains (store.GetValue (iter, 2));
				store.SetValue (iter, 3, sel);
				UpdateSelectionChecks (iter);
			}
			while (store.IterNext (ref iter));
		}
		
		void SelectCommonCombine (CombineEntry e)
		{
			CombineEntry common = GetCommonCombineEntry ();
			selectedEntries [common] = common;
			CombineEntry[] entries = new CombineEntry [selectedEntries.Count];
			selectedEntries.Keys.CopyTo (entries, 0);
			foreach (CombineEntry se in entries) {
				CombineEntry ce = se;
				while (ce != null && ce != common) {
					selectedEntries [ce] = ce;
					ce = ce.ParentCombine;
				}
			}
			UpdateSelectionChecks (TreeIter.Zero);
		}
		
		CombineEntry GetCommonCombineEntry ()
		{
			ArrayList combineList = new ArrayList ();
			bool firstEntry = true;
			foreach (CombineEntry e in selectedEntries.Keys) {
				CombineEntry c = e;
				do {
					int i = combineList.IndexOf (c);
					if (i != -1) {
						// Found a common entry.
						// Remove all previous entries in the list, since they are not common.
						combineList.RemoveRange (0, i);
						break;
					} else if (firstEntry) {
						combineList.Add (c);
					}
					c = c.ParentCombine;
				}
				while (c != null);
				
				firstEntry = false;
			}
			return (CombineEntry) combineList [0];
		}
	}
}

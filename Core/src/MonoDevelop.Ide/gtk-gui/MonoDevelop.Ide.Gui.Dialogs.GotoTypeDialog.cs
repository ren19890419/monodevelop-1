// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class GotoTypeDialog {
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView treeview1;
        
        private Gtk.Button button1;
        
        private Gtk.Button button4;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog";
            this.Title = Mono.Unix.Catalog.GetString("Go to Type");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow1.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            this.scrolledwindow1.BorderWidth = ((uint)(12));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.treeview1 = new Gtk.TreeView();
            this.treeview1.CanFocus = true;
            this.treeview1.Name = "treeview1";
            this.scrolledwindow1.Add(this.treeview1);
            w1.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[this.scrolledwindow1]));
            w3.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog.ActionArea
            Gtk.HButtonBox w4 = this.ActionArea;
            w4.Events = ((Gdk.EventMask)(256));
            w4.Name = "MonoDevelop.Ide.GotoTypeDialog_ActionArea";
            w4.Spacing = 10;
            w4.BorderWidth = ((uint)(5));
            w4.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.Ide.GotoTypeDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanDefault = true;
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseStock = true;
            this.button1.UseUnderline = true;
            this.button1.Label = "gtk-cancel";
            this.AddActionWidget(this.button1, -6);
            Gtk.ButtonBox.ButtonBoxChild w5 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[this.button1]));
            w5.Expand = false;
            w5.Fill = false;
            // Container child MonoDevelop.Ide.GotoTypeDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button4 = new Gtk.Button();
            this.button4.CanDefault = true;
            this.button4.CanFocus = true;
            this.button4.Name = "button4";
            this.button4.UseStock = true;
            this.button4.UseUnderline = true;
            this.button4.Label = "gtk-ok";
            this.AddActionWidget(this.button4, -5);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[this.button4]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.treeview1.RowActivated += new Gtk.RowActivatedHandler(this.RowActivated);
            this.button1.Clicked += new System.EventHandler(this.CancelClicked);
            this.button4.Clicked += new System.EventHandler(this.OkClicked);
        }
    }
}

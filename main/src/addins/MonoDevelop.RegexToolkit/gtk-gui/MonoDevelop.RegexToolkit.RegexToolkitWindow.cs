// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.RegexToolkit {
    
    
    public partial class RegexToolkitWindow {
        
        private Gtk.VBox vbox2;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox6;
        
        private Gtk.Notebook notebook1;
        
        private Gtk.ScrolledWindow scrolledwindow7;
        
        private Gtk.TextView regExTextview;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow5;
        
        private Gtk.TreeView optionsTreeview;
        
        private Gtk.Label label2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label label5;
        
        private Gtk.ScrolledWindow scrolledwindow3;
        
        private Gtk.TextView replaceTextview;
        
        private Gtk.VBox vbox4;
        
        private Gtk.Label label6;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView inputTextview;
        
        private Gtk.VBox vbox5;
        
        private Gtk.Label label7;
        
        private Gtk.ScrolledWindow elementsscrolledwindow;
        
        private Gtk.TreeView elementsTreeview;
        
        private Gtk.Notebook notebook2;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView resultsTreeview;
        
        private Gtk.Label label3;
        
        private Gtk.ScrolledWindow scrolledwindow4;
        
        private Gtk.TextView replaceResultTextview;
        
        private Gtk.Label label4;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonSearch;
        
        private Gtk.Button buttonSearchReplace;
        
        private Gtk.Button buttonLibrary;
        
        private Gtk.Button buttonCancel;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.RegexToolkit.RegexToolkitWindow
            this.Name = "MonoDevelop.RegexToolkit.RegexToolkitWindow";
            this.Title = Mono.Unix.Catalog.GetString("Regular Expression Toolkit");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child MonoDevelop.RegexToolkit.RegexToolkitWindow.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 371;
            this.vpaned1.BorderWidth = ((uint)(6));
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 356;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            // Container child vbox6.Gtk.Box+BoxChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 0;
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.scrolledwindow7 = new Gtk.ScrolledWindow();
            this.scrolledwindow7.CanFocus = true;
            this.scrolledwindow7.Name = "scrolledwindow7";
            this.scrolledwindow7.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow7.Gtk.Container+ContainerChild
            this.regExTextview = new Gtk.TextView();
            this.regExTextview.CanFocus = true;
            this.regExTextview.Name = "regExTextview";
            this.scrolledwindow7.Add(this.regExTextview);
            this.notebook1.Add(this.scrolledwindow7);
            // Notebook tab
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Regular Expression");
            this.notebook1.SetTabLabel(this.scrolledwindow7, this.label1);
            this.label1.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.scrolledwindow5 = new Gtk.ScrolledWindow();
            this.scrolledwindow5.CanFocus = true;
            this.scrolledwindow5.Name = "scrolledwindow5";
            this.scrolledwindow5.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow5.Gtk.Container+ContainerChild
            Gtk.Viewport w3 = new Gtk.Viewport();
            w3.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.optionsTreeview = new Gtk.TreeView();
            this.optionsTreeview.CanFocus = true;
            this.optionsTreeview.Name = "optionsTreeview";
            this.optionsTreeview.HeadersClickable = true;
            w3.Add(this.optionsTreeview);
            this.scrolledwindow5.Add(w3);
            this.notebook1.Add(this.scrolledwindow5);
            Gtk.Notebook.NotebookChild w6 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.scrolledwindow5]));
            w6.Position = 1;
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Options");
            this.notebook1.SetTabLabel(this.scrolledwindow5, this.label2);
            this.label2.ShowAll();
            this.vbox6.Add(this.notebook1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox6[this.notebook1]));
            w7.Position = 0;
            // Container child vbox6.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Replace Regex");
            this.vbox3.Add(this.label5);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.label5]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.scrolledwindow3 = new Gtk.ScrolledWindow();
            this.scrolledwindow3.CanFocus = true;
            this.scrolledwindow3.Name = "scrolledwindow3";
            this.scrolledwindow3.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow3.Gtk.Container+ContainerChild
            this.replaceTextview = new Gtk.TextView();
            this.replaceTextview.CanFocus = true;
            this.replaceTextview.Name = "replaceTextview";
            this.scrolledwindow3.Add(this.replaceTextview);
            this.vbox3.Add(this.scrolledwindow3);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox3[this.scrolledwindow3]));
            w10.Position = 1;
            this.vbox6.Add(this.vbox3);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox6[this.vbox3]));
            w11.Position = 1;
            // Container child vbox6.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Input");
            this.vbox4.Add(this.label6);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox4[this.label6]));
            w12.Position = 0;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.inputTextview = new Gtk.TextView();
            this.inputTextview.CanFocus = true;
            this.inputTextview.Name = "inputTextview";
            this.scrolledwindow1.Add(this.inputTextview);
            this.vbox4.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox4[this.scrolledwindow1]));
            w14.Position = 1;
            this.vbox6.Add(this.vbox4);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox6[this.vbox4]));
            w15.Position = 2;
            this.hpaned1.Add(this.vbox6);
            Gtk.Paned.PanedChild w16 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox6]));
            w16.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Regex Elements");
            this.vbox5.Add(this.label7);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox5[this.label7]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.elementsscrolledwindow = new Gtk.ScrolledWindow();
            this.elementsscrolledwindow.CanFocus = true;
            this.elementsscrolledwindow.Name = "elementsscrolledwindow";
            this.elementsscrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child elementsscrolledwindow.Gtk.Container+ContainerChild
            this.elementsTreeview = new Gtk.TreeView();
            this.elementsTreeview.CanFocus = true;
            this.elementsTreeview.Name = "elementsTreeview";
            this.elementsTreeview.HeadersClickable = true;
            this.elementsscrolledwindow.Add(this.elementsTreeview);
            this.vbox5.Add(this.elementsscrolledwindow);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox5[this.elementsscrolledwindow]));
            w19.Position = 1;
            this.hpaned1.Add(this.vbox5);
            this.vpaned1.Add(this.hpaned1);
            Gtk.Paned.PanedChild w21 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.hpaned1]));
            w21.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.notebook2 = new Gtk.Notebook();
            this.notebook2.CanFocus = true;
            this.notebook2.Name = "notebook2";
            this.notebook2.CurrentPage = 0;
            // Container child notebook2.Gtk.Notebook+NotebookChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.resultsTreeview = new Gtk.TreeView();
            this.resultsTreeview.CanFocus = true;
            this.resultsTreeview.Name = "resultsTreeview";
            this.resultsTreeview.HeadersClickable = true;
            this.scrolledwindow2.Add(this.resultsTreeview);
            this.notebook2.Add(this.scrolledwindow2);
            // Notebook tab
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Matches");
            this.notebook2.SetTabLabel(this.scrolledwindow2, this.label3);
            this.label3.ShowAll();
            // Container child notebook2.Gtk.Notebook+NotebookChild
            this.scrolledwindow4 = new Gtk.ScrolledWindow();
            this.scrolledwindow4.CanFocus = true;
            this.scrolledwindow4.Name = "scrolledwindow4";
            this.scrolledwindow4.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow4.Gtk.Container+ContainerChild
            this.replaceResultTextview = new Gtk.TextView();
            this.replaceResultTextview.CanFocus = true;
            this.replaceResultTextview.Name = "replaceResultTextview";
            this.replaceResultTextview.Editable = false;
            this.replaceResultTextview.CursorVisible = false;
            this.scrolledwindow4.Add(this.replaceResultTextview);
            this.notebook2.Add(this.scrolledwindow4);
            Gtk.Notebook.NotebookChild w25 = ((Gtk.Notebook.NotebookChild)(this.notebook2[this.scrolledwindow4]));
            w25.Position = 1;
            // Notebook tab
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Replace");
            this.notebook2.SetTabLabel(this.scrolledwindow4, this.label4);
            this.label4.ShowAll();
            this.vpaned1.Add(this.notebook2);
            this.vbox2.Add(this.vpaned1);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox2[this.vpaned1]));
            w27.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearch = new Gtk.Button();
            this.buttonSearch.CanDefault = true;
            this.buttonSearch.CanFocus = true;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.UseStock = true;
            this.buttonSearch.UseUnderline = true;
            this.buttonSearch.Label = "gtk-find";
            this.hbox1.Add(this.buttonSearch);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearch]));
            w28.PackType = ((Gtk.PackType)(1));
            w28.Position = 0;
            w28.Expand = false;
            w28.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearchReplace = new Gtk.Button();
            this.buttonSearchReplace.CanDefault = true;
            this.buttonSearchReplace.CanFocus = true;
            this.buttonSearchReplace.Name = "buttonSearchReplace";
            this.buttonSearchReplace.UseStock = true;
            this.buttonSearchReplace.UseUnderline = true;
            this.buttonSearchReplace.Label = "gtk-find-and-replace";
            this.hbox1.Add(this.buttonSearchReplace);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchReplace]));
            w29.PackType = ((Gtk.PackType)(1));
            w29.Position = 1;
            w29.Expand = false;
            w29.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonLibrary = new Gtk.Button();
            this.buttonLibrary.CanDefault = true;
            this.buttonLibrary.CanFocus = true;
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.UseUnderline = true;
            this.buttonLibrary.Label = Mono.Unix.Catalog.GetString("Regex Library");
            this.hbox1.Add(this.buttonLibrary);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonLibrary]));
            w30.PackType = ((Gtk.PackType)(1));
            w30.Position = 2;
            w30.Expand = false;
            w30.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-close";
            this.hbox1.Add(this.buttonCancel);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
            w31.PackType = ((Gtk.PackType)(1));
            w31.Position = 3;
            w31.Expand = false;
            w31.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w32.Position = 1;
            w32.Expand = false;
            w32.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 706;
            this.DefaultHeight = 663;
            this.Show();
        }
    }
}

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.Components {
    
    
    public partial class ConnectionSettingsWidget {
        
        private Gtk.Table table;
        
        private Gtk.Button buttonTest;
        
        private Gtk.Entry entryName;
        
        private Gtk.Entry entryServer;
        
        private Gtk.Entry entryUsername;
        
        private Gtk.Expander expander;
        
        private Gtk.Table tableAdvanced;
        
        private Gtk.CheckButton checkCustom;
        
        private Gtk.Label label10;
        
        private Gtk.Label label11;
        
        private Gtk.ScrolledWindow scrolledwindow;
        
        private Gtk.TextView textConnectionString;
        
        private Gtk.SpinButton spinMaxPoolSize;
        
        private Gtk.SpinButton spinMinPoolSize;
        
        private Gtk.Label GtkLabel5;
        
        private Gtk.HBox hboxDatabase;
        
        private Gtk.ComboBoxEntry comboDatabase;
        
        private Gtk.Button buttonRefresh;
        
        private Gtk.Button buttonOpen;
        
        private Gtk.HBox hboxPassword;
        
        private Gtk.Entry entryPassword;
        
        private Gtk.CheckButton checkSavePassword;
        
        private Gtk.Label labelDatabase;
        
        private Gtk.Label labelName;
        
        private Gtk.Label labelPassword;
        
        private Gtk.Label labelPort;
        
        private Gtk.Label labelServer;
        
        private Gtk.Label labelTest;
        
        private Gtk.Label labelUsername;
        
        private Gtk.SpinButton spinPort;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Components.ConnectionSettingsWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Components.ConnectionSettingsWidget";
            // Container child MonoDevelop.Database.Components.ConnectionSettingsWidget.Gtk.Container+ContainerChild
            this.table = new Gtk.Table(((uint)(8)), ((uint)(2)), false);
            this.table.Name = "table";
            this.table.RowSpacing = ((uint)(6));
            this.table.ColumnSpacing = ((uint)(6));
            this.table.BorderWidth = ((uint)(6));
            // Container child table.Gtk.Table+TableChild
            this.buttonTest = new Gtk.Button();
            this.buttonTest.CanFocus = true;
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.UseUnderline = true;
            // Container child buttonTest.Gtk.Container+ContainerChild
            Gtk.Alignment w1 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w2 = new Gtk.HBox();
            w2.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w3 = new Gtk.Image();
            w3.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-apply", Gtk.IconSize.Menu, 16);
            w2.Add(w3);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w5 = new Gtk.Label();
            w5.LabelProp = Mono.Unix.Catalog.GetString("Test");
            w5.UseUnderline = true;
            w2.Add(w5);
            w1.Add(w2);
            this.buttonTest.Add(w1);
            this.table.Add(this.buttonTest);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table[this.buttonTest]));
            w9.TopAttach = ((uint)(7));
            w9.BottomAttach = ((uint)(8));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.entryName = new Gtk.Entry();
            this.entryName.CanDefault = true;
            this.entryName.CanFocus = true;
            this.entryName.Name = "entryName";
            this.entryName.IsEditable = true;
            this.entryName.ActivatesDefault = true;
            this.entryName.InvisibleChar = '●';
            this.table.Add(this.entryName);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table[this.entryName]));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.entryServer = new Gtk.Entry();
            this.entryServer.CanFocus = true;
            this.entryServer.Name = "entryServer";
            this.entryServer.IsEditable = true;
            this.entryServer.InvisibleChar = '●';
            this.table.Add(this.entryServer);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table[this.entryServer]));
            w11.TopAttach = ((uint)(1));
            w11.BottomAttach = ((uint)(2));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.entryUsername = new Gtk.Entry();
            this.entryUsername.CanFocus = true;
            this.entryUsername.Name = "entryUsername";
            this.entryUsername.IsEditable = true;
            this.entryUsername.InvisibleChar = '●';
            this.table.Add(this.entryUsername);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table[this.entryUsername]));
            w12.TopAttach = ((uint)(3));
            w12.BottomAttach = ((uint)(4));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.expander = new Gtk.Expander(null);
            this.expander.CanFocus = true;
            this.expander.Name = "expander";
            this.expander.Expanded = true;
            // Container child expander.Gtk.Container+ContainerChild
            this.tableAdvanced = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.tableAdvanced.Name = "tableAdvanced";
            this.tableAdvanced.RowSpacing = ((uint)(6));
            this.tableAdvanced.ColumnSpacing = ((uint)(6));
            this.tableAdvanced.BorderWidth = ((uint)(6));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.checkCustom = new Gtk.CheckButton();
            this.checkCustom.CanFocus = true;
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Label = Mono.Unix.Catalog.GetString("Use custom connection string");
            this.checkCustom.DrawIndicator = true;
            this.checkCustom.UseUnderline = true;
            this.tableAdvanced.Add(this.checkCustom);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.checkCustom]));
            w13.TopAttach = ((uint)(2));
            w13.BottomAttach = ((uint)(3));
            w13.RightAttach = ((uint)(2));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.label10 = new Gtk.Label();
            this.label10.Name = "label10";
            this.label10.Xalign = 0F;
            this.label10.LabelProp = Mono.Unix.Catalog.GetString("Min Pool Size");
            this.tableAdvanced.Add(this.label10);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.label10]));
            w14.XOptions = ((Gtk.AttachOptions)(4));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("Max Pool Size");
            this.tableAdvanced.Add(this.label11);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.label11]));
            w15.TopAttach = ((uint)(1));
            w15.BottomAttach = ((uint)(2));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.scrolledwindow = new Gtk.ScrolledWindow();
            this.scrolledwindow.Sensitive = false;
            this.scrolledwindow.CanFocus = true;
            this.scrolledwindow.Name = "scrolledwindow";
            this.scrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow.Gtk.Container+ContainerChild
            this.textConnectionString = new Gtk.TextView();
            this.textConnectionString.CanFocus = true;
            this.textConnectionString.Name = "textConnectionString";
            this.scrolledwindow.Add(this.textConnectionString);
            this.tableAdvanced.Add(this.scrolledwindow);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.scrolledwindow]));
            w17.TopAttach = ((uint)(3));
            w17.BottomAttach = ((uint)(4));
            w17.RightAttach = ((uint)(2));
            w17.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.spinMaxPoolSize = new Gtk.SpinButton(1, 100, 1);
            this.spinMaxPoolSize.CanFocus = true;
            this.spinMaxPoolSize.Name = "spinMaxPoolSize";
            this.spinMaxPoolSize.Adjustment.PageIncrement = 10;
            this.spinMaxPoolSize.ClimbRate = 1;
            this.spinMaxPoolSize.Numeric = true;
            this.spinMaxPoolSize.Value = 5;
            this.tableAdvanced.Add(this.spinMaxPoolSize);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.spinMaxPoolSize]));
            w18.TopAttach = ((uint)(1));
            w18.BottomAttach = ((uint)(2));
            w18.LeftAttach = ((uint)(1));
            w18.RightAttach = ((uint)(2));
            w18.XOptions = ((Gtk.AttachOptions)(4));
            w18.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableAdvanced.Gtk.Table+TableChild
            this.spinMinPoolSize = new Gtk.SpinButton(1, 100, 1);
            this.spinMinPoolSize.CanFocus = true;
            this.spinMinPoolSize.Name = "spinMinPoolSize";
            this.spinMinPoolSize.Adjustment.PageIncrement = 10;
            this.spinMinPoolSize.ClimbRate = 1;
            this.spinMinPoolSize.Numeric = true;
            this.spinMinPoolSize.Value = 1;
            this.tableAdvanced.Add(this.spinMinPoolSize);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.tableAdvanced[this.spinMinPoolSize]));
            w19.LeftAttach = ((uint)(1));
            w19.RightAttach = ((uint)(2));
            w19.XOptions = ((Gtk.AttachOptions)(4));
            w19.YOptions = ((Gtk.AttachOptions)(4));
            this.expander.Add(this.tableAdvanced);
            this.GtkLabel5 = new Gtk.Label();
            this.GtkLabel5.Name = "GtkLabel5";
            this.GtkLabel5.LabelProp = Mono.Unix.Catalog.GetString("Advanced");
            this.GtkLabel5.UseUnderline = true;
            this.expander.LabelWidget = this.GtkLabel5;
            this.table.Add(this.expander);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table[this.expander]));
            w21.TopAttach = ((uint)(6));
            w21.BottomAttach = ((uint)(7));
            w21.RightAttach = ((uint)(2));
            w21.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.hboxDatabase = new Gtk.HBox();
            this.hboxDatabase.Name = "hboxDatabase";
            this.hboxDatabase.Spacing = 6;
            // Container child hboxDatabase.Gtk.Box+BoxChild
            this.comboDatabase = Gtk.ComboBoxEntry.NewText();
            this.comboDatabase.Name = "comboDatabase";
            this.hboxDatabase.Add(this.comboDatabase);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hboxDatabase[this.comboDatabase]));
            w22.Position = 0;
            // Container child hboxDatabase.Gtk.Box+BoxChild
            this.buttonRefresh = new Gtk.Button();
            this.buttonRefresh.CanFocus = true;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseStock = true;
            this.buttonRefresh.UseUnderline = true;
            this.buttonRefresh.Label = "gtk-refresh";
            this.hboxDatabase.Add(this.buttonRefresh);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hboxDatabase[this.buttonRefresh]));
            w23.Position = 1;
            w23.Expand = false;
            w23.Fill = false;
            // Container child hboxDatabase.Gtk.Box+BoxChild
            this.buttonOpen = new Gtk.Button();
            this.buttonOpen.CanFocus = true;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.UseStock = true;
            this.buttonOpen.UseUnderline = true;
            this.buttonOpen.Label = "gtk-open";
            this.hboxDatabase.Add(this.buttonOpen);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.hboxDatabase[this.buttonOpen]));
            w24.Position = 2;
            w24.Expand = false;
            w24.Fill = false;
            this.table.Add(this.hboxDatabase);
            Gtk.Table.TableChild w25 = ((Gtk.Table.TableChild)(this.table[this.hboxDatabase]));
            w25.TopAttach = ((uint)(5));
            w25.BottomAttach = ((uint)(6));
            w25.LeftAttach = ((uint)(1));
            w25.RightAttach = ((uint)(2));
            w25.XOptions = ((Gtk.AttachOptions)(4));
            w25.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.hboxPassword = new Gtk.HBox();
            this.hboxPassword.Name = "hboxPassword";
            this.hboxPassword.Spacing = 6;
            // Container child hboxPassword.Gtk.Box+BoxChild
            this.entryPassword = new Gtk.Entry();
            this.entryPassword.CanFocus = true;
            this.entryPassword.Name = "entryPassword";
            this.entryPassword.IsEditable = true;
            this.entryPassword.Visibility = false;
            this.entryPassword.InvisibleChar = '●';
            this.hboxPassword.Add(this.entryPassword);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.hboxPassword[this.entryPassword]));
            w26.Position = 0;
            // Container child hboxPassword.Gtk.Box+BoxChild
            this.checkSavePassword = new Gtk.CheckButton();
            this.checkSavePassword.CanFocus = true;
            this.checkSavePassword.Name = "checkSavePassword";
            this.checkSavePassword.Label = Mono.Unix.Catalog.GetString("Save Password");
            this.checkSavePassword.Active = true;
            this.checkSavePassword.DrawIndicator = true;
            this.checkSavePassword.UseUnderline = true;
            this.hboxPassword.Add(this.checkSavePassword);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.hboxPassword[this.checkSavePassword]));
            w27.Position = 1;
            w27.Expand = false;
            this.table.Add(this.hboxPassword);
            Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.table[this.hboxPassword]));
            w28.TopAttach = ((uint)(4));
            w28.BottomAttach = ((uint)(5));
            w28.LeftAttach = ((uint)(1));
            w28.RightAttach = ((uint)(2));
            w28.XOptions = ((Gtk.AttachOptions)(4));
            w28.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelDatabase = new Gtk.Label();
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Xalign = 0F;
            this.labelDatabase.LabelProp = Mono.Unix.Catalog.GetString("Database");
            this.table.Add(this.labelDatabase);
            Gtk.Table.TableChild w29 = ((Gtk.Table.TableChild)(this.table[this.labelDatabase]));
            w29.TopAttach = ((uint)(5));
            w29.BottomAttach = ((uint)(6));
            w29.XOptions = ((Gtk.AttachOptions)(4));
            w29.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelName = new Gtk.Label();
            this.labelName.Name = "labelName";
            this.labelName.Xalign = 0F;
            this.labelName.LabelProp = Mono.Unix.Catalog.GetString("Name");
            this.table.Add(this.labelName);
            Gtk.Table.TableChild w30 = ((Gtk.Table.TableChild)(this.table[this.labelName]));
            w30.XOptions = ((Gtk.AttachOptions)(4));
            w30.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelPassword = new Gtk.Label();
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Xalign = 0F;
            this.labelPassword.LabelProp = Mono.Unix.Catalog.GetString("Password");
            this.table.Add(this.labelPassword);
            Gtk.Table.TableChild w31 = ((Gtk.Table.TableChild)(this.table[this.labelPassword]));
            w31.TopAttach = ((uint)(4));
            w31.BottomAttach = ((uint)(5));
            w31.XOptions = ((Gtk.AttachOptions)(4));
            w31.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelPort = new Gtk.Label();
            this.labelPort.Name = "labelPort";
            this.labelPort.Xalign = 0F;
            this.labelPort.LabelProp = Mono.Unix.Catalog.GetString("Port");
            this.table.Add(this.labelPort);
            Gtk.Table.TableChild w32 = ((Gtk.Table.TableChild)(this.table[this.labelPort]));
            w32.TopAttach = ((uint)(2));
            w32.BottomAttach = ((uint)(3));
            w32.XOptions = ((Gtk.AttachOptions)(4));
            w32.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelServer = new Gtk.Label();
            this.labelServer.Name = "labelServer";
            this.labelServer.Xalign = 0F;
            this.labelServer.LabelProp = Mono.Unix.Catalog.GetString("Server");
            this.table.Add(this.labelServer);
            Gtk.Table.TableChild w33 = ((Gtk.Table.TableChild)(this.table[this.labelServer]));
            w33.TopAttach = ((uint)(1));
            w33.BottomAttach = ((uint)(2));
            w33.XOptions = ((Gtk.AttachOptions)(4));
            w33.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelTest = new Gtk.Label();
            this.labelTest.Name = "labelTest";
            this.labelTest.Xalign = 0F;
            this.labelTest.LabelProp = "";
            this.labelTest.Wrap = true;
            this.table.Add(this.labelTest);
            Gtk.Table.TableChild w34 = ((Gtk.Table.TableChild)(this.table[this.labelTest]));
            w34.TopAttach = ((uint)(7));
            w34.BottomAttach = ((uint)(8));
            w34.LeftAttach = ((uint)(1));
            w34.RightAttach = ((uint)(2));
            w34.XOptions = ((Gtk.AttachOptions)(4));
            w34.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.labelUsername = new Gtk.Label();
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Xalign = 0F;
            this.labelUsername.LabelProp = Mono.Unix.Catalog.GetString("Username");
            this.table.Add(this.labelUsername);
            Gtk.Table.TableChild w35 = ((Gtk.Table.TableChild)(this.table[this.labelUsername]));
            w35.TopAttach = ((uint)(3));
            w35.BottomAttach = ((uint)(4));
            w35.XOptions = ((Gtk.AttachOptions)(4));
            w35.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table.Gtk.Table+TableChild
            this.spinPort = new Gtk.SpinButton(1, 65535, 1);
            this.spinPort.CanFocus = true;
            this.spinPort.Name = "spinPort";
            this.spinPort.Adjustment.PageIncrement = 10;
            this.spinPort.ClimbRate = 1;
            this.spinPort.Numeric = true;
            this.spinPort.Value = 1;
            this.table.Add(this.spinPort);
            Gtk.Table.TableChild w36 = ((Gtk.Table.TableChild)(this.table[this.spinPort]));
            w36.TopAttach = ((uint)(2));
            w36.BottomAttach = ((uint)(3));
            w36.LeftAttach = ((uint)(1));
            w36.RightAttach = ((uint)(2));
            w36.XOptions = ((Gtk.AttachOptions)(4));
            w36.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.table);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.spinPort.Changed += new System.EventHandler(this.PortChanged);
            this.entryPassword.Changed += new System.EventHandler(this.PasswordChanged);
            this.buttonRefresh.Clicked += new System.EventHandler(this.RefreshClicked);
            this.buttonOpen.Clicked += new System.EventHandler(this.OpenClicked);
            this.spinMinPoolSize.Changed += new System.EventHandler(this.MinPoolSizeChanged);
            this.spinMaxPoolSize.Changed += new System.EventHandler(this.MaxPoolSizeChanged);
            this.entryUsername.Changed += new System.EventHandler(this.UsernameChanged);
            this.entryServer.Changed += new System.EventHandler(this.ServerChanged);
            this.entryName.Changed += new System.EventHandler(this.NameChanged);
            this.buttonTest.Clicked += new System.EventHandler(this.TestClicked);
        }
    }
}

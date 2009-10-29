// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Projects.Gui.Dialogs.OptionPanels {
    
    internal partial class GeneralProjectOptionsWidget {
        
        private Gtk.VBox vbox40;
        
        private Gtk.VBox vbox47;
        
        private Gtk.Label informationHeaderLabel;
        
        private Gtk.HBox hbox29;
        
        private Gtk.Label label55;
        
        private Gtk.VBox vbox46;
        
        private Gtk.Table table11;
        
        private Gtk.Label defaultNamespaceLabel;
        
        private Gtk.Label descriptionLabel;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Entry entryVersion;
        
        private Gtk.CheckButton checkSolutionVersion;
        
        private Gtk.Label label1;
        
        private Gtk.Label nameLabel;
        
        private Gtk.Entry projectDefaultNamespaceEntry;
        
        private Gtk.Entry projectNameEntry;
        
        private Gtk.ScrolledWindow scrolledwindow5;
        
        private Gtk.TextView projectDescriptionTextView;
        
        private Gtk.VBox vbox41;
        
        private Gtk.Label onProjectLoadHeaderLabel;
        
        private Gtk.HBox hbox26;
        
        private Gtk.Label label49;
        
        private Gtk.CheckButton newFilesOnLoadCheckButton;
        
        private Gtk.HBox hbox27;
        
        private Gtk.Label label50;
        
        private Gtk.CheckButton autoInsertNewFilesCheckButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget";
            // Container child MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget.Gtk.Container+ContainerChild
            this.vbox40 = new Gtk.VBox();
            this.vbox40.Name = "vbox40";
            this.vbox40.Spacing = 12;
            // Container child vbox40.Gtk.Box+BoxChild
            this.vbox47 = new Gtk.VBox();
            this.vbox47.Name = "vbox47";
            this.vbox47.Spacing = 6;
            // Container child vbox47.Gtk.Box+BoxChild
            this.informationHeaderLabel = new Gtk.Label();
            this.informationHeaderLabel.Name = "informationHeaderLabel";
            this.informationHeaderLabel.Xalign = 0F;
            this.informationHeaderLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<b>Project Information</b>");
            this.informationHeaderLabel.UseMarkup = true;
            this.informationHeaderLabel.UseUnderline = true;
            this.vbox47.Add(this.informationHeaderLabel);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox47[this.informationHeaderLabel]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox47.Gtk.Box+BoxChild
            this.hbox29 = new Gtk.HBox();
            this.hbox29.Name = "hbox29";
            // Container child hbox29.Gtk.Box+BoxChild
            this.label55 = new Gtk.Label();
            this.label55.WidthRequest = 18;
            this.label55.Name = "label55";
            this.hbox29.Add(this.label55);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox29[this.label55]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox29.Gtk.Box+BoxChild
            this.vbox46 = new Gtk.VBox();
            this.vbox46.Name = "vbox46";
            this.vbox46.Spacing = 6;
            // Container child vbox46.Gtk.Box+BoxChild
            this.table11 = new Gtk.Table(((uint)(5)), ((uint)(2)), false);
            this.table11.Name = "table11";
            this.table11.RowSpacing = ((uint)(6));
            this.table11.ColumnSpacing = ((uint)(6));
            // Container child table11.Gtk.Table+TableChild
            this.defaultNamespaceLabel = new Gtk.Label();
            this.defaultNamespaceLabel.Name = "defaultNamespaceLabel";
            this.defaultNamespaceLabel.Xalign = 0F;
            this.defaultNamespaceLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Default Namespace:");
            this.table11.Add(this.defaultNamespaceLabel);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table11[this.defaultNamespaceLabel]));
            w3.TopAttach = ((uint)(3));
            w3.BottomAttach = ((uint)(4));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            // Container child table11.Gtk.Table+TableChild
            this.descriptionLabel = new Gtk.Label();
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Xalign = 0F;
            this.descriptionLabel.Yalign = 0F;
            this.descriptionLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Description:");
            this.descriptionLabel.UseUnderline = true;
            this.table11.Add(this.descriptionLabel);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table11[this.descriptionLabel]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            // Container child table11.Gtk.Table+TableChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.entryVersion = new Gtk.Entry();
            this.entryVersion.CanFocus = true;
            this.entryVersion.Name = "entryVersion";
            this.entryVersion.IsEditable = true;
            this.entryVersion.InvisibleChar = '●';
            this.hbox1.Add(this.entryVersion);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.entryVersion]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.checkSolutionVersion = new Gtk.CheckButton();
            this.checkSolutionVersion.CanFocus = true;
            this.checkSolutionVersion.Name = "checkSolutionVersion";
            this.checkSolutionVersion.Label = MonoDevelop.Core.GettextCatalog.GetString("Get version from parent solution");
            this.checkSolutionVersion.DrawIndicator = true;
            this.checkSolutionVersion.UseUnderline = true;
            this.hbox1.Add(this.checkSolutionVersion);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.checkSolutionVersion]));
            w6.Position = 1;
            this.table11.Add(this.hbox1);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table11[this.hbox1]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table11.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Version:");
            this.table11.Add(this.label1);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table11[this.label1]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table11.Gtk.Table+TableChild
            this.nameLabel = new Gtk.Label();
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Xalign = 0F;
            this.nameLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Name:");
            this.nameLabel.UseUnderline = true;
            this.table11.Add(this.nameLabel);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table11[this.nameLabel]));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.projectDefaultNamespaceEntry = new Gtk.Entry();
            this.projectDefaultNamespaceEntry.Name = "projectDefaultNamespaceEntry";
            this.projectDefaultNamespaceEntry.IsEditable = true;
            this.projectDefaultNamespaceEntry.InvisibleChar = '●';
            this.table11.Add(this.projectDefaultNamespaceEntry);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table11[this.projectDefaultNamespaceEntry]));
            w10.TopAttach = ((uint)(3));
            w10.BottomAttach = ((uint)(4));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.projectNameEntry = new Gtk.Entry();
            this.projectNameEntry.Name = "projectNameEntry";
            this.projectNameEntry.IsEditable = true;
            this.projectNameEntry.InvisibleChar = '●';
            this.table11.Add(this.projectNameEntry);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table11[this.projectNameEntry]));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.scrolledwindow5 = new Gtk.ScrolledWindow();
            this.scrolledwindow5.WidthRequest = 350;
            this.scrolledwindow5.HeightRequest = 100;
            this.scrolledwindow5.Name = "scrolledwindow5";
            this.scrolledwindow5.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow5.Gtk.Container+ContainerChild
            this.projectDescriptionTextView = new Gtk.TextView();
            this.projectDescriptionTextView.Name = "projectDescriptionTextView";
            this.scrolledwindow5.Add(this.projectDescriptionTextView);
            this.table11.Add(this.scrolledwindow5);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table11[this.scrolledwindow5]));
            w13.TopAttach = ((uint)(2));
            w13.BottomAttach = ((uint)(3));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            this.vbox46.Add(this.table11);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox46[this.table11]));
            w14.Position = 0;
            this.hbox29.Add(this.vbox46);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox29[this.vbox46]));
            w15.Position = 1;
            this.vbox47.Add(this.hbox29);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox47[this.hbox29]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            this.vbox40.Add(this.vbox47);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox40[this.vbox47]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox40.Gtk.Box+BoxChild
            this.vbox41 = new Gtk.VBox();
            this.vbox41.Name = "vbox41";
            this.vbox41.Spacing = 6;
            // Container child vbox41.Gtk.Box+BoxChild
            this.onProjectLoadHeaderLabel = new Gtk.Label();
            this.onProjectLoadHeaderLabel.Name = "onProjectLoadHeaderLabel";
            this.onProjectLoadHeaderLabel.Xalign = 0F;
            this.onProjectLoadHeaderLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<b>On Project Load</b>");
            this.onProjectLoadHeaderLabel.UseMarkup = true;
            this.onProjectLoadHeaderLabel.UseUnderline = true;
            this.vbox41.Add(this.onProjectLoadHeaderLabel);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox41[this.onProjectLoadHeaderLabel]));
            w18.Position = 0;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox41.Gtk.Box+BoxChild
            this.hbox26 = new Gtk.HBox();
            this.hbox26.Name = "hbox26";
            // Container child hbox26.Gtk.Box+BoxChild
            this.label49 = new Gtk.Label();
            this.label49.WidthRequest = 18;
            this.label49.Name = "label49";
            this.hbox26.Add(this.label49);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox26[this.label49]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Container child hbox26.Gtk.Box+BoxChild
            this.newFilesOnLoadCheckButton = new Gtk.CheckButton();
            this.newFilesOnLoadCheckButton.Name = "newFilesOnLoadCheckButton";
            this.newFilesOnLoadCheckButton.Label = MonoDevelop.Core.GettextCatalog.GetString("Search for new _files on load");
            this.newFilesOnLoadCheckButton.DrawIndicator = true;
            this.newFilesOnLoadCheckButton.UseUnderline = true;
            this.hbox26.Add(this.newFilesOnLoadCheckButton);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox26[this.newFilesOnLoadCheckButton]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            this.vbox41.Add(this.hbox26);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox41[this.hbox26]));
            w21.Position = 1;
            w21.Expand = false;
            w21.Fill = false;
            // Container child vbox41.Gtk.Box+BoxChild
            this.hbox27 = new Gtk.HBox();
            this.hbox27.Name = "hbox27";
            // Container child hbox27.Gtk.Box+BoxChild
            this.label50 = new Gtk.Label();
            this.label50.WidthRequest = 18;
            this.label50.Name = "label50";
            this.hbox27.Add(this.label50);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox27[this.label50]));
            w22.Position = 0;
            w22.Expand = false;
            w22.Fill = false;
            // Container child hbox27.Gtk.Box+BoxChild
            this.autoInsertNewFilesCheckButton = new Gtk.CheckButton();
            this.autoInsertNewFilesCheckButton.Name = "autoInsertNewFilesCheckButton";
            this.autoInsertNewFilesCheckButton.Label = MonoDevelop.Core.GettextCatalog.GetString("Automatically _include found files");
            this.autoInsertNewFilesCheckButton.DrawIndicator = true;
            this.autoInsertNewFilesCheckButton.UseUnderline = true;
            this.hbox27.Add(this.autoInsertNewFilesCheckButton);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox27[this.autoInsertNewFilesCheckButton]));
            w23.Position = 1;
            w23.Expand = false;
            w23.Fill = false;
            this.vbox41.Add(this.hbox27);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox41[this.hbox27]));
            w24.Position = 2;
            w24.Expand = false;
            w24.Fill = false;
            this.vbox40.Add(this.vbox41);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox40[this.vbox41]));
            w25.Position = 1;
            w25.Expand = false;
            w25.Fill = false;
            this.Add(this.vbox40);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.descriptionLabel.MnemonicWidget = this.scrolledwindow5;
            this.nameLabel.MnemonicWidget = this.projectNameEntry;
            this.Show();
            this.checkSolutionVersion.Clicked += new System.EventHandler(this.OnCheckSolutionVersionClicked);
        }
    }
}

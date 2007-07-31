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
    
    
    public partial class EncapsulateFieldDialog {
        
        private Gtk.VBox vbox;
        
        private Gtk.Table tableName;
        
        private Gtk.Entry entryFieldName;
        
        private Gtk.Entry entryPropertyName;
        
        private Gtk.Label labelFieldName;
        
        private Gtk.Label labelPropertyName;
        
        private Gtk.Label labelUpdateRefs;
        
        private Gtk.HBox hboxUpdateRefs;
        
        private Gtk.Label labelSpacer;
        
        private Gtk.VBox vboxUpdateChoices;
        
        private Gtk.RadioButton radioUpdateExternal;
        
        private Gtk.RadioButton radioUpdateAll;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog";
            this.Title = Mono.Unix.Catalog.GetString("Encapsulate Field");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox = new Gtk.VBox();
            this.vbox.Name = "vbox";
            this.vbox.Spacing = 6;
            this.vbox.BorderWidth = ((uint)(6));
            // Container child vbox.Gtk.Box+BoxChild
            this.tableName = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.tableName.Name = "tableName";
            this.tableName.RowSpacing = ((uint)(6));
            this.tableName.ColumnSpacing = ((uint)(6));
            // Container child tableName.Gtk.Table+TableChild
            this.entryFieldName = new Gtk.Entry();
            this.entryFieldName.Sensitive = false;
            this.entryFieldName.CanFocus = true;
            this.entryFieldName.Name = "entryFieldName";
            this.entryFieldName.IsEditable = true;
            this.entryFieldName.InvisibleChar = '●';
            this.tableName.Add(this.entryFieldName);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.tableName[this.entryFieldName]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableName.Gtk.Table+TableChild
            this.entryPropertyName = new Gtk.Entry();
            this.entryPropertyName.CanFocus = true;
            this.entryPropertyName.Name = "entryPropertyName";
            this.entryPropertyName.IsEditable = true;
            this.entryPropertyName.InvisibleChar = '●';
            this.tableName.Add(this.entryPropertyName);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.tableName[this.entryPropertyName]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableName.Gtk.Table+TableChild
            this.labelFieldName = new Gtk.Label();
            this.labelFieldName.Name = "labelFieldName";
            this.labelFieldName.Xalign = 0F;
            this.labelFieldName.LabelProp = Mono.Unix.Catalog.GetString("Field name:");
            this.tableName.Add(this.labelFieldName);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.tableName[this.labelFieldName]));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableName.Gtk.Table+TableChild
            this.labelPropertyName = new Gtk.Label();
            this.labelPropertyName.Name = "labelPropertyName";
            this.labelPropertyName.Xalign = 0F;
            this.labelPropertyName.LabelProp = Mono.Unix.Catalog.GetString("_Property name:");
            this.labelPropertyName.UseUnderline = true;
            this.tableName.Add(this.labelPropertyName);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.tableName[this.labelPropertyName]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox.Add(this.tableName);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox[this.tableName]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.labelUpdateRefs = new Gtk.Label();
            this.labelUpdateRefs.Name = "labelUpdateRefs";
            this.labelUpdateRefs.Xalign = 0F;
            this.labelUpdateRefs.LabelProp = Mono.Unix.Catalog.GetString("_Update references:");
            this.labelUpdateRefs.UseUnderline = true;
            this.vbox.Add(this.labelUpdateRefs);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox[this.labelUpdateRefs]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hboxUpdateRefs = new Gtk.HBox();
            this.hboxUpdateRefs.Name = "hboxUpdateRefs";
            this.hboxUpdateRefs.Spacing = 6;
            // Container child hboxUpdateRefs.Gtk.Box+BoxChild
            this.labelSpacer = new Gtk.Label();
            this.labelSpacer.Name = "labelSpacer";
            this.labelSpacer.Xalign = 0F;
            this.labelSpacer.LabelProp = Mono.Unix.Catalog.GetString("    ");
            this.hboxUpdateRefs.Add(this.labelSpacer);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hboxUpdateRefs[this.labelSpacer]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child hboxUpdateRefs.Gtk.Box+BoxChild
            this.vboxUpdateChoices = new Gtk.VBox();
            this.vboxUpdateChoices.Name = "vboxUpdateChoices";
            this.vboxUpdateChoices.Spacing = 6;
            // Container child vboxUpdateChoices.Gtk.Box+BoxChild
            this.radioUpdateExternal = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_External"));
            this.radioUpdateExternal.CanFocus = true;
            this.radioUpdateExternal.Name = "radioUpdateExternal";
            this.radioUpdateExternal.Active = true;
            this.radioUpdateExternal.DrawIndicator = true;
            this.radioUpdateExternal.UseUnderline = true;
            this.radioUpdateExternal.Group = new GLib.SList(System.IntPtr.Zero);
            this.vboxUpdateChoices.Add(this.radioUpdateExternal);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vboxUpdateChoices[this.radioUpdateExternal]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vboxUpdateChoices.Gtk.Box+BoxChild
            this.radioUpdateAll = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_All"));
            this.radioUpdateAll.CanFocus = true;
            this.radioUpdateAll.Name = "radioUpdateAll";
            this.radioUpdateAll.DrawIndicator = true;
            this.radioUpdateAll.UseUnderline = true;
            this.radioUpdateAll.Group = this.radioUpdateExternal.Group;
            this.vboxUpdateChoices.Add(this.radioUpdateAll);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vboxUpdateChoices[this.radioUpdateAll]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            this.hboxUpdateRefs.Add(this.vboxUpdateChoices);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hboxUpdateRefs[this.vboxUpdateChoices]));
            w11.Position = 1;
            this.vbox.Add(this.hboxUpdateRefs);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox[this.hboxUpdateRefs]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            w1.Add(this.vbox);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(w1[this.vbox]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog.ActionArea
            Gtk.HButtonBox w14 = this.ActionArea;
            w14.Name = "dialog1_ActionArea";
            w14.Spacing = 10;
            w14.BorderWidth = ((uint)(5));
            w14.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w15 = ((Gtk.ButtonBox.ButtonBoxChild)(w14[this.buttonCancel]));
            w15.Expand = false;
            w15.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w16 = ((Gtk.ButtonBox.ButtonBoxChild)(w14[this.buttonOk]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 413;
            this.DefaultHeight = 247;
            this.Show();
        }
    }
}

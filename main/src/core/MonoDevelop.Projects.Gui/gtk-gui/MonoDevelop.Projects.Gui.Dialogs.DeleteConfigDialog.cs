// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Projects.Gui.Dialogs {
    
    internal partial class DeleteConfigDialog {
        
        private Gtk.HBox hbox64;
        
        private Gtk.Image image6;
        
        private Gtk.VBox vbox80;
        
        private Gtk.Label label107;
        
        private Gtk.CheckButton deleteChildrenCheck;
        
        private Gtk.Button button11;
        
        private Gtk.Button button12;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Projects.Gui.Dialogs.DeleteConfigDialog
            this.Name = "MonoDevelop.Projects.Gui.Dialogs.DeleteConfigDialog";
            this.Title = MonoDevelop.Core.GettextCatalog.GetString("Delete Configuration");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            // Internal child MonoDevelop.Projects.Gui.Dialogs.DeleteConfigDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox7";
            // Container child dialog-vbox7.Gtk.Box+BoxChild
            this.hbox64 = new Gtk.HBox();
            this.hbox64.Name = "hbox64";
            this.hbox64.Spacing = 12;
            this.hbox64.BorderWidth = ((uint)(12));
            // Container child hbox64.Gtk.Box+BoxChild
            this.image6 = new Gtk.Image();
            this.image6.Name = "image6";
            this.image6.Yalign = 0F;
            this.image6.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-question", Gtk.IconSize.Dialog, 48);
            this.hbox64.Add(this.image6);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox64[this.image6]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox64.Gtk.Box+BoxChild
            this.vbox80 = new Gtk.VBox();
            this.vbox80.Name = "vbox80";
            this.vbox80.Spacing = 6;
            // Container child vbox80.Gtk.Box+BoxChild
            this.label107 = new Gtk.Label();
            this.label107.Name = "label107";
            this.label107.Xalign = 0F;
            this.label107.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Are you sure you want to delete this configuration?");
            this.vbox80.Add(this.label107);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox80[this.label107]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox80.Gtk.Box+BoxChild
            this.deleteChildrenCheck = new Gtk.CheckButton();
            this.deleteChildrenCheck.Name = "deleteChildrenCheck";
            this.deleteChildrenCheck.Label = MonoDevelop.Core.GettextCatalog.GetString("Delete also configurations in solution items");
            this.deleteChildrenCheck.Active = true;
            this.deleteChildrenCheck.DrawIndicator = true;
            this.deleteChildrenCheck.UseUnderline = true;
            this.vbox80.Add(this.deleteChildrenCheck);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox80[this.deleteChildrenCheck]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.hbox64.Add(this.vbox80);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox64[this.vbox80]));
            w5.Position = 1;
            w1.Add(this.hbox64);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(w1[this.hbox64]));
            w6.Position = 2;
            // Internal child MonoDevelop.Projects.Gui.Dialogs.DeleteConfigDialog.ActionArea
            Gtk.HButtonBox w7 = this.ActionArea;
            w7.Name = "dialog-action_area7";
            w7.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area7.Gtk.ButtonBox+ButtonBoxChild
            this.button11 = new Gtk.Button();
            this.button11.Name = "button11";
            this.button11.UseStock = true;
            this.button11.UseUnderline = true;
            this.button11.Label = "gtk-no";
            this.AddActionWidget(this.button11, -9);
            // Container child dialog-action_area7.Gtk.ButtonBox+ButtonBoxChild
            this.button12 = new Gtk.Button();
            this.button12.CanDefault = true;
            this.button12.Name = "button12";
            this.button12.UseStock = true;
            this.button12.UseUnderline = true;
            this.button12.Label = "gtk-yes";
            this.AddActionWidget(this.button12, -8);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.button12]));
            w9.Position = 1;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 0;
            this.DefaultHeight = 0;
            this.Show();
        }
    }
}

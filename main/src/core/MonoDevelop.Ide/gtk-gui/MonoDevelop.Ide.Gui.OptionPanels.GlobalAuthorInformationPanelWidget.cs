
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Gui.OptionPanels
{
	internal partial class GlobalAuthorInformationPanelWidget
	{
		private global::Gtk.Table table1;

		private global::Gtk.Entry copyrightEntry;

		private global::Gtk.Entry emailEntry;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Entry nameEntry;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Gui.OptionPanels.GlobalAuthorInformationPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.Gui.OptionPanels.GlobalAuthorInformationPanelWidget";
			// Container child MonoDevelop.Ide.Gui.OptionPanels.GlobalAuthorInformationPanelWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.copyrightEntry = new global::Gtk.Entry ();
			this.copyrightEntry.CanFocus = true;
			this.copyrightEntry.Name = "copyrightEntry";
			this.copyrightEntry.IsEditable = true;
			this.copyrightEntry.InvisibleChar = '●';
			this.table1.Add (this.copyrightEntry);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.copyrightEntry]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.emailEntry = new global::Gtk.Entry ();
			this.emailEntry.CanFocus = true;
			this.emailEntry.Name = "emailEntry";
			this.emailEntry.IsEditable = true;
			this.emailEntry.InvisibleChar = '●';
			this.table1.Add (this.emailEntry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.emailEntry]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("_Name:");
			this.label2.UseUnderline = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("_Copyright:");
			this.label3.UseUnderline = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0f;
			this.label4.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("_Email:");
			this.label4.UseUnderline = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nameEntry = new global::Gtk.Entry ();
			this.nameEntry.CanFocus = true;
			this.nameEntry.Name = "nameEntry";
			this.nameEntry.IsEditable = true;
			this.nameEntry.InvisibleChar = '●';
			this.table1.Add (this.nameEntry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.nameEntry]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label2.MnemonicWidget = this.nameEntry;
			this.Hide ();
		}
	}
}

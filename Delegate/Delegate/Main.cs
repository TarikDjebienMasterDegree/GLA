using System;
using Gtk;

namespace WindowsFormsApplication2
{
	public delegate void LangageDelegate ();

	public partial class Form1 : Form
	{
		public LangageDelegate langageDelegate;

		public Form1 ()
		{
			InitializeComponent ();
			langageDelegate = changeMessageFR;
		}

		public static void changeMessageIT ()
		{
			MessageBox.Show ("Il vostro Messaggio:Hello");
		}

		public static void changeMessageFR ()
		{
			MessageBox.Show ("Votre message:Hello");
		}

		public static void changeMessageEN ()
		{
			MessageBox.Show ("Your message:Hello");
		}

		private void buttonGo_Click (object sender, EventArgs e)
		{
			langageDelegate ();
		}

		private void checkBoxItalia_CheckedChanged (object sender, EventArgs e)
		{
			if (((CheckBox)sender).Checked) {
				langageDelegate += changeMessageIT;
			} else {
				langageDelegate -= changeMessageIT;
			}
		}

		private void checkBoxUSA_CheckedChanged (object sender, EventArgs e)
		{
			if (((CheckBox)sender).Checked) {
				langageDelegate += changeMessageEN;
			} else {
				langageDelegate -= changeMessageEN;
			}
		}
	}
}
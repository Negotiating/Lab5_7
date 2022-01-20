using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lab5_button_Click(object sender, EventArgs e)
		{
			lab5_form newForm = new lab5_form();
			newForm.ShowDialog();
		}

		private void lab7_button_Click(object sender, EventArgs e)
		{
			lab7_form newForm = new lab7_form();
			newForm.ShowDialog();
		}
	}
}

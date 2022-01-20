using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Lab5_7
{
	public partial class lab7_form : Form
	{
		public lab7_form()
		{
			InitializeComponent();
		}

		private void file_box_Click(object sender, EventArgs e)
		{
			//выбираем файл
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				path_label.Text = folderBrowserDialog.SelectedPath;
			var rez =
			Directory
				.GetFiles(path_label.Text, "*.txt", SearchOption.AllDirectories)
				.ToList().First();
			FileInfo fileInfo = new FileInfo(rez);
			if (fileInfo.Type != "txt")
				info_box.Text = "Формат файла не txt";
			info_box.Text = fileInfo.GetInfo();
		}
	}
}

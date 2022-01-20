namespace Lab5_7
{
	partial class lab7_form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.file_box = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.path_label = new System.Windows.Forms.Label();
			this.info_box = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// file_box
			// 
			this.file_box.Location = new System.Drawing.Point(12, 12);
			this.file_box.Name = "file_box";
			this.file_box.Size = new System.Drawing.Size(127, 23);
			this.file_box.TabIndex = 0;
			this.file_box.Text = "Выбор файла";
			this.file_box.UseVisualStyleBackColor = true;
			this.file_box.Click += new System.EventHandler(this.file_box_Click);
			// 
			// path_label
			// 
			this.path_label.AutoSize = true;
			this.path_label.Location = new System.Drawing.Point(12, 38);
			this.path_label.Name = "path_label";
			this.path_label.Size = new System.Drawing.Size(0, 13);
			this.path_label.TabIndex = 1;
			// 
			// info_box
			// 
			this.info_box.Location = new System.Drawing.Point(15, 70);
			this.info_box.Multiline = true;
			this.info_box.Name = "info_box";
			this.info_box.Size = new System.Drawing.Size(332, 234);
			this.info_box.TabIndex = 2;
			// 
			// lab7_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 316);
			this.Controls.Add(this.info_box);
			this.Controls.Add(this.path_label);
			this.Controls.Add(this.file_box);
			this.Name = "lab7_form";
			this.Text = "Лабораторная работа 7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button file_box;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Label path_label;
		private System.Windows.Forms.TextBox info_box;
	}
}
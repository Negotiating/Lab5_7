namespace Lab5_7
{
	partial class lab5_form
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
			this.components = new System.ComponentModel.Container();
			this.task_control = new System.Windows.Forms.TabControl();
			this.exception_page = new System.Windows.Forms.TabPage();
			this.timer_page = new System.Windows.Forms.TabPage();
			this.file_page = new System.Windows.Forms.TabPage();
			this.task1_box = new System.Windows.Forms.GroupBox();
			this.task2_box = new System.Windows.Forms.GroupBox();
			this.task3_box = new System.Windows.Forms.GroupBox();
			this.x2_button = new System.Windows.Forms.Button();
			this.value_textbox = new System.Windows.Forms.TextBox();
			this.img_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.znamenatel_textbox = new System.Windows.Forms.TextBox();
			this.chislitel_textbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rezult_textbox = new System.Windows.Forms.TextBox();
			this.getrezult_button = new System.Windows.Forms.Button();
			this.open_button = new System.Windows.Forms.Button();
			this.currenttime_box = new System.Windows.Forms.TextBox();
			this.currenttime_label = new System.Windows.Forms.Label();
			this.knopocka = new System.Windows.Forms.Button();
			this.tozhe_knopocka = new System.Windows.Forms.Button();
			this.start_button = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.Stop_button = new System.Windows.Forms.Button();
			this.calendar = new System.Windows.Forms.DateTimePicker();
			this.calendar_box = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.directory_box = new System.Windows.Forms.TextBox();
			this.rezult_box = new System.Windows.Forms.TextBox();
			this.task_control.SuspendLayout();
			this.exception_page.SuspendLayout();
			this.timer_page.SuspendLayout();
			this.file_page.SuspendLayout();
			this.task1_box.SuspendLayout();
			this.task2_box.SuspendLayout();
			this.task3_box.SuspendLayout();
			this.SuspendLayout();
			// 
			// task_control
			// 
			this.task_control.Controls.Add(this.exception_page);
			this.task_control.Controls.Add(this.timer_page);
			this.task_control.Controls.Add(this.file_page);
			this.task_control.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task_control.Location = new System.Drawing.Point(0, 0);
			this.task_control.Name = "task_control";
			this.task_control.SelectedIndex = 0;
			this.task_control.Size = new System.Drawing.Size(411, 248);
			this.task_control.TabIndex = 0;
			// 
			// exception_page
			// 
			this.exception_page.Controls.Add(this.task3_box);
			this.exception_page.Controls.Add(this.task2_box);
			this.exception_page.Controls.Add(this.task1_box);
			this.exception_page.Location = new System.Drawing.Point(4, 22);
			this.exception_page.Name = "exception_page";
			this.exception_page.Padding = new System.Windows.Forms.Padding(3);
			this.exception_page.Size = new System.Drawing.Size(403, 222);
			this.exception_page.TabIndex = 0;
			this.exception_page.Text = "Обработка исключительных ситуаций";
			this.exception_page.UseVisualStyleBackColor = true;
			// 
			// timer_page
			// 
			this.timer_page.Controls.Add(this.calendar_box);
			this.timer_page.Controls.Add(this.calendar);
			this.timer_page.Controls.Add(this.Stop_button);
			this.timer_page.Controls.Add(this.start_button);
			this.timer_page.Controls.Add(this.tozhe_knopocka);
			this.timer_page.Controls.Add(this.knopocka);
			this.timer_page.Controls.Add(this.currenttime_label);
			this.timer_page.Controls.Add(this.currenttime_box);
			this.timer_page.Location = new System.Drawing.Point(4, 22);
			this.timer_page.Name = "timer_page";
			this.timer_page.Padding = new System.Windows.Forms.Padding(3);
			this.timer_page.Size = new System.Drawing.Size(403, 222);
			this.timer_page.TabIndex = 1;
			this.timer_page.Text = "Таймер и календарь";
			this.timer_page.UseVisualStyleBackColor = true;
			// 
			// file_page
			// 
			this.file_page.Controls.Add(this.rezult_box);
			this.file_page.Controls.Add(this.directory_box);
			this.file_page.Controls.Add(this.button2);
			this.file_page.Location = new System.Drawing.Point(4, 22);
			this.file_page.Name = "file_page";
			this.file_page.Size = new System.Drawing.Size(403, 222);
			this.file_page.TabIndex = 2;
			this.file_page.Text = "Работа с файлами и директориями";
			this.file_page.UseVisualStyleBackColor = true;
			// 
			// task1_box
			// 
			this.task1_box.Controls.Add(this.value_textbox);
			this.task1_box.Controls.Add(this.x2_button);
			this.task1_box.Location = new System.Drawing.Point(8, 6);
			this.task1_box.Name = "task1_box";
			this.task1_box.Size = new System.Drawing.Size(200, 88);
			this.task1_box.TabIndex = 0;
			this.task1_box.TabStop = false;
			this.task1_box.Text = "Задание 1";
			// 
			// task2_box
			// 
			this.task2_box.Controls.Add(this.open_button);
			this.task2_box.Controls.Add(this.button1);
			this.task2_box.Controls.Add(this.img_button);
			this.task2_box.Location = new System.Drawing.Point(8, 100);
			this.task2_box.Name = "task2_box";
			this.task2_box.Size = new System.Drawing.Size(241, 111);
			this.task2_box.TabIndex = 1;
			this.task2_box.TabStop = false;
			this.task2_box.Text = "Задание 2";
			// 
			// task3_box
			// 
			this.task3_box.Controls.Add(this.getrezult_button);
			this.task3_box.Controls.Add(this.rezult_textbox);
			this.task3_box.Controls.Add(this.label2);
			this.task3_box.Controls.Add(this.label1);
			this.task3_box.Controls.Add(this.chislitel_textbox);
			this.task3_box.Controls.Add(this.znamenatel_textbox);
			this.task3_box.Location = new System.Drawing.Point(255, 6);
			this.task3_box.Name = "task3_box";
			this.task3_box.Size = new System.Drawing.Size(140, 205);
			this.task3_box.TabIndex = 2;
			this.task3_box.TabStop = false;
			this.task3_box.Text = "Задание 3";
			// 
			// x2_button
			// 
			this.x2_button.Location = new System.Drawing.Point(57, 55);
			this.x2_button.Name = "x2_button";
			this.x2_button.Size = new System.Drawing.Size(75, 23);
			this.x2_button.TabIndex = 0;
			this.x2_button.Text = "*2";
			this.x2_button.UseVisualStyleBackColor = true;
			this.x2_button.Click += new System.EventHandler(this.x2_button_Click);
			// 
			// value_textbox
			// 
			this.value_textbox.Location = new System.Drawing.Point(7, 29);
			this.value_textbox.Name = "value_textbox";
			this.value_textbox.Size = new System.Drawing.Size(187, 20);
			this.value_textbox.TabIndex = 1;
			// 
			// img_button
			// 
			this.img_button.Location = new System.Drawing.Point(6, 19);
			this.img_button.Name = "img_button";
			this.img_button.Size = new System.Drawing.Size(188, 41);
			this.img_button.TabIndex = 0;
			this.img_button.Text = "Загрузить картинку на вторую форму";
			this.img_button.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Загрузить текст на третью форму";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// znamenatel_textbox
			// 
			this.znamenatel_textbox.Location = new System.Drawing.Point(24, 29);
			this.znamenatel_textbox.Name = "znamenatel_textbox";
			this.znamenatel_textbox.Size = new System.Drawing.Size(100, 20);
			this.znamenatel_textbox.TabIndex = 0;
			// 
			// chislitel_textbox
			// 
			this.chislitel_textbox.Location = new System.Drawing.Point(24, 57);
			this.chislitel_textbox.Name = "chislitel_textbox";
			this.chislitel_textbox.Size = new System.Drawing.Size(100, 20);
			this.chislitel_textbox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "/";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "=";
			// 
			// rezult_textbox
			// 
			this.rezult_textbox.Location = new System.Drawing.Point(24, 94);
			this.rezult_textbox.Name = "rezult_textbox";
			this.rezult_textbox.ReadOnly = true;
			this.rezult_textbox.Size = new System.Drawing.Size(100, 20);
			this.rezult_textbox.TabIndex = 4;
			// 
			// getrezult_button
			// 
			this.getrezult_button.Location = new System.Drawing.Point(24, 131);
			this.getrezult_button.Name = "getrezult_button";
			this.getrezult_button.Size = new System.Drawing.Size(100, 23);
			this.getrezult_button.TabIndex = 5;
			this.getrezult_button.Text = "Результат";
			this.getrezult_button.UseVisualStyleBackColor = true;
			this.getrezult_button.Click += new System.EventHandler(this.getrezult_button_Click);
			// 
			// open_button
			// 
			this.open_button.Location = new System.Drawing.Point(200, 52);
			this.open_button.Name = "open_button";
			this.open_button.Size = new System.Drawing.Size(27, 23);
			this.open_button.TabIndex = 2;
			this.open_button.Text = "OP";
			this.open_button.UseVisualStyleBackColor = true;
			// 
			// currenttime_box
			// 
			this.currenttime_box.Location = new System.Drawing.Point(101, 3);
			this.currenttime_box.Name = "currenttime_box";
			this.currenttime_box.ReadOnly = true;
			this.currenttime_box.Size = new System.Drawing.Size(199, 20);
			this.currenttime_box.TabIndex = 0;
			// 
			// currenttime_label
			// 
			this.currenttime_label.AutoSize = true;
			this.currenttime_label.Location = new System.Drawing.Point(8, 6);
			this.currenttime_label.Name = "currenttime_label";
			this.currenttime_label.Size = new System.Drawing.Size(87, 13);
			this.currenttime_label.TabIndex = 1;
			this.currenttime_label.Text = "Текущее время";
			// 
			// knopocka
			// 
			this.knopocka.Location = new System.Drawing.Point(11, 64);
			this.knopocka.Name = "knopocka";
			this.knopocka.Size = new System.Drawing.Size(97, 23);
			this.knopocka.TabIndex = 2;
			this.knopocka.Text = "knopocka";
			this.knopocka.UseVisualStyleBackColor = true;
			this.knopocka.Click += new System.EventHandler(this.knopocka_Click);
			// 
			// tozhe_knopocka
			// 
			this.tozhe_knopocka.Location = new System.Drawing.Point(11, 93);
			this.tozhe_knopocka.Name = "tozhe_knopocka";
			this.tozhe_knopocka.Size = new System.Drawing.Size(97, 23);
			this.tozhe_knopocka.TabIndex = 3;
			this.tozhe_knopocka.Text = "tozhe_knopocka";
			this.tozhe_knopocka.UseVisualStyleBackColor = true;
			this.tozhe_knopocka.Click += new System.EventHandler(this.tozhe_knopocka_Click);
			// 
			// start_button
			// 
			this.start_button.Location = new System.Drawing.Point(11, 37);
			this.start_button.Name = "start_button";
			this.start_button.Size = new System.Drawing.Size(68, 21);
			this.start_button.TabIndex = 4;
			this.start_button.Text = "Старт";
			this.start_button.UseVisualStyleBackColor = true;
			this.start_button.Click += new System.EventHandler(this.start_button_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Stop_button
			// 
			this.Stop_button.Location = new System.Drawing.Point(86, 37);
			this.Stop_button.Name = "Stop_button";
			this.Stop_button.Size = new System.Drawing.Size(75, 21);
			this.Stop_button.TabIndex = 5;
			this.Stop_button.Text = "Стоп";
			this.Stop_button.UseVisualStyleBackColor = true;
			this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
			// 
			// calendar
			// 
			this.calendar.Location = new System.Drawing.Point(11, 122);
			this.calendar.Name = "calendar";
			this.calendar.Size = new System.Drawing.Size(200, 20);
			this.calendar.TabIndex = 6;
			this.calendar.ValueChanged += new System.EventHandler(this.calendar_ValueChanged);
			// 
			// calendar_box
			// 
			this.calendar_box.Location = new System.Drawing.Point(11, 148);
			this.calendar_box.Name = "calendar_box";
			this.calendar_box.Size = new System.Drawing.Size(384, 20);
			this.calendar_box.TabIndex = 7;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(232, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Выполнить поиск текстовых файлов";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// directory_box
			// 
			this.directory_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.directory_box.Location = new System.Drawing.Point(8, 41);
			this.directory_box.Name = "directory_box";
			this.directory_box.ReadOnly = true;
			this.directory_box.Size = new System.Drawing.Size(387, 13);
			this.directory_box.TabIndex = 1;
			// 
			// rezult_box
			// 
			this.rezult_box.Location = new System.Drawing.Point(8, 60);
			this.rezult_box.Multiline = true;
			this.rezult_box.Name = "rezult_box";
			this.rezult_box.Size = new System.Drawing.Size(387, 159);
			this.rezult_box.TabIndex = 2;
			// 
			// lab5_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 248);
			this.Controls.Add(this.task_control);
			this.Name = "lab5_form";
			this.Text = "Лабораторная работа 5";
			this.Load += new System.EventHandler(this.lab5_form_Load);
			this.task_control.ResumeLayout(false);
			this.exception_page.ResumeLayout(false);
			this.timer_page.ResumeLayout(false);
			this.timer_page.PerformLayout();
			this.file_page.ResumeLayout(false);
			this.file_page.PerformLayout();
			this.task1_box.ResumeLayout(false);
			this.task1_box.PerformLayout();
			this.task2_box.ResumeLayout(false);
			this.task3_box.ResumeLayout(false);
			this.task3_box.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl task_control;
		private System.Windows.Forms.TabPage exception_page;
		private System.Windows.Forms.GroupBox task3_box;
		private System.Windows.Forms.Button getrezult_button;
		private System.Windows.Forms.TextBox rezult_textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox chislitel_textbox;
		private System.Windows.Forms.TextBox znamenatel_textbox;
		private System.Windows.Forms.GroupBox task2_box;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button img_button;
		private System.Windows.Forms.GroupBox task1_box;
		private System.Windows.Forms.TextBox value_textbox;
		private System.Windows.Forms.Button x2_button;
		private System.Windows.Forms.TabPage timer_page;
		private System.Windows.Forms.TabPage file_page;
		private System.Windows.Forms.Button open_button;
		private System.Windows.Forms.Label currenttime_label;
		private System.Windows.Forms.TextBox currenttime_box;
		private System.Windows.Forms.Button start_button;
		private System.Windows.Forms.Button tozhe_knopocka;
		private System.Windows.Forms.Button knopocka;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button Stop_button;
		private System.Windows.Forms.TextBox calendar_box;
		private System.Windows.Forms.DateTimePicker calendar;
		private System.Windows.Forms.TextBox rezult_box;
		private System.Windows.Forms.TextBox directory_box;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}
namespace Lab5_7
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lab5_button = new System.Windows.Forms.Button();
			this.lab7_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lab5_button
			// 
			this.lab5_button.Location = new System.Drawing.Point(12, 12);
			this.lab5_button.Name = "lab5_button";
			this.lab5_button.Size = new System.Drawing.Size(243, 56);
			this.lab5_button.TabIndex = 0;
			this.lab5_button.Text = "Лабораторная работа 5";
			this.lab5_button.UseVisualStyleBackColor = true;
			this.lab5_button.Click += new System.EventHandler(this.lab5_button_Click);
			// 
			// lab7_button
			// 
			this.lab7_button.Location = new System.Drawing.Point(12, 74);
			this.lab7_button.Name = "lab7_button";
			this.lab7_button.Size = new System.Drawing.Size(243, 56);
			this.lab7_button.TabIndex = 1;
			this.lab7_button.Text = "Лабораторная работа 7";
			this.lab7_button.UseVisualStyleBackColor = true;
			this.lab7_button.Click += new System.EventHandler(this.lab7_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 146);
			this.Controls.Add(this.lab7_button);
			this.Controls.Add(this.lab5_button);
			this.Name = "Form1";
			this.Text = "Лабораторные работы";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button lab5_button;
		private System.Windows.Forms.Button lab7_button;
	}
}


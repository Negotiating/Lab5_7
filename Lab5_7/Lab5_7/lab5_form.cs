using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Lab5_7
{
	public partial class lab5_form : Form
	{
		public lab5_form()
		{
			InitializeComponent();
		}

		private void x2_button_Click(object sender, EventArgs e)
		{
			//Объявляем переменную
			double val=0;
			try
			{
				//пытаемся инициализировать переменную значением из текстбокса
				//при некорректном вводе генерируется ошибка FormatException
				val = Convert.ToDouble(value_textbox.Text);
			}
			catch(Exception ex)
			{
				//выводим сообщение об ошибке, если инициализация не удалась
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error ,MessageBoxDefaultButton.Button1);
			}
			//в текстбокс помещаем результат 
			value_textbox.Text = (val * 2).ToString();
		}

		private void getrezult_button_Click(object sender, EventArgs e)
		{
			try
			{
				double v1 = 0, v2 = 0;
				//Если введена пустая строка или недалось преобразовать в тип double, то генерируется исключение
				if (string.IsNullOrEmpty(znamenatel_textbox.Text)
					|| string.IsNullOrEmpty(chislitel_textbox.Text)
					|| !double.TryParse(znamenatel_textbox.Text, out v1)
					|| !double.TryParse(chislitel_textbox.Text, out v2))
					throw new Exception("Некорректный ввод!");
				else
				{
					rezult_textbox.Text = (v1 * v2).ToString();
				}

			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void lab5_form_Load(object sender, EventArgs e)
		{
			
		}
		//задаем начальные значения скорости кнопок
		int px1 = 10, px2 = 10;
		DateTime time;
		DateTime starttime;
		private void start_button_Click(object sender, EventArgs e)
		{
			timer.Enabled = true;
			//Запускаем таймер
			timer.Start();
			//назначаем время старта
			starttime = DateTime.Now;
			
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//каждую секунду выводится информация о текущем времени
			currenttime_box.Text = DateTime.Now.ToLongTimeString();
			//обновляется время гонки
			time = DateTime.Now;
			//двигаем кнопки
			knopocka.Left += px1;
			tozhe_knopocka.Left += px2;
		}
		//ускорение при нажатии на кнопку
		private void knopocka_Click(object sender, EventArgs e) =>
			px1 += 5;
		
		private void tozhe_knopocka_Click(object sender, EventArgs e) =>
			px1 += 5;
		
		private void Stop_button_Click(object sender, EventArgs e)
		{
			//останавливаем таймер и движение кнопок
			timer.Stop();
			//выводим время гонки
			MessageBox.Show($"Время гонки: {time - starttime}");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//выбираем директорию
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				directory_box.Text = folderBrowserDialog.SelectedPath;
			//формируем список файлов 
			var rez = 
			Directory
				.GetFiles(directory_box.Text, "*.txt", SearchOption.AllDirectories)
				.ToList();
			//выводим из в текстбокс
			foreach (var r in rez)
				rezult_box.Text += r.ToString() + "\n";
		}

		//получение дня недели выбранного дня
		private void calendar_ValueChanged(object sender, EventArgs e)=>
			calendar_box.Text = $"День недели {calendar.Value.DayOfWeek}";

		
	}
}

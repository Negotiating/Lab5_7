using System;
using Info = System.IO.FileInfo;
using File = System.IO.File;


namespace Lab5_7
{
	internal class FileInfo
	{
		private string _filename;
		private DateTime _filedate;
		private string _directory;
		private string _path;
		private int _linequantity;
		private int _charquantity;
		private string _type;

		public string FileName
		{
			get => _filename;
			set
			{
				_filename = value;
			}
		}
		public DateTime FileDate
		{
			get => _filedate;
		}
		public int Linequantity
		{
			get => _linequantity; 
		}
		public int Charquantity
		{
			get => _charquantity;
		}
		public string Path
		{
			get => _path;
		}
		public string Directory
		{
			get => _directory;	
		}
		public string Type
		{
			get => _type;
		}
		public FileInfo(string path)
		{
			Info info = new Info(path);
			_filename = info.Name;
			_filedate = info.LastWriteTime;
			_directory = info.DirectoryName;
			_path = info.FullName;
			_type = info.Extension;
		}
		public int GetSpases()
		{
			//считываем данные из файла
			System.IO.StreamReader sr = new System.IO.StreamReader(Path);
			string text = sr.ReadToEnd();
			int i = 0;
			//считаем количество пробельных символов
			foreach (char c in text)
				if (char.IsWhiteSpace(c))
					i++;
			return i;
		}
		public int GetLines()
		{
			string[] lines = File.ReadAllLines(Path);
			return lines.Length;
		}
		public string GetInfo() =>
			 $" Name: {FileName}\n Date: {FileDate}\n Directory: {Directory}\n Spases: {GetSpases()}\n Line: {GetLines()}";
		
	}
}

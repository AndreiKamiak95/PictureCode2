/*
 * Создано в SharpDevelop.
 * Пользователь: KAMIAK
 * Дата: 17.07.2018
 * Время: 14:22
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PictureCode2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap pict;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static byte SetBit(byte val, int num,bool bit)
		{
			if ((num> 7) || (num< 0))//Проверка входных данных
			{
			   throw new ArgumentException();
			}
			byte tmpval = 1;
			tmpval = (byte)(tmpval<<num);//устанавливаем нужный бит в единицу
			val = (byte)(val& (~tmpval));//сбрасываем в 0 нужный бит
			
			if (bit)// если бит требуется установить в 1
			{
			   val = (byte)(val | (tmpval));//то устанавливаем нужный бит в 1
			}
			return val;
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnOpenClick(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Pictures|*.bmp;*.png;*.jpg;*.jpeg;*.ico|All files|*.*";
			openFileDialog1.FileName = "";
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pict = new Bitmap(openFileDialog1.FileName);
				pictureBox.Image = pict;
				btnConvert.Enabled = true;
			}
		}
		void BtnConvertClick(object sender, EventArgs e)
		{
			int width = pict.Width;
			int height = pict.Height;
			int width_byte = pict.Width/8;
			byte segment = 0;
			string line = "";
			Color pixel;
			textBox.Text = "";
			
			if(width%8 != 0)
			{
				width_byte++;
			}
			textBox.Text += "0x"+Convert.ToString(height, 16) + ", 0x00, " + "0x"+Convert.ToString(width_byte, 16) + 
								", 0x00," + Environment.NewLine;
			
			for(int j = 0; j < height; j++)
			{
				for(int i = 0; i < width; i+=8)
				{
					segment = 0;
					
					for(int k = 0; k < 8; k++)
					{
						try
						{
							pixel = pict.GetPixel(i+k,j);
							if((pixel.R < 230) && (pixel.G < 230) && (pixel.B != 230))
							{
								segment = SetBit(segment, 7-k, true);
							}
						}
						catch(Exception)
						{
							break;
						}
					}
					line += "0x"+Convert.ToString(segment, 16)+",";
				}
				line += Environment.NewLine;
			}
			textBox.Text += line;
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Кодировщик картинок версия 2\n" +
			                "Конвертирует картинки в бинарный формат\n"+
			                "Нулевой байт в массиве - высота в битах, второй - ширина в байтах\n"+
			               	"Отрисовку начинать с четвертого байта\n"+
			               	"Пиксель не фиксируется, если его значение больше 230 по трем каналам");
		}
		void TextBoxTextChanged(object sender, EventArgs e)
		{
			/*textBox.SelectionStart = 0;
			textBox.SelectionLength = textBox.Text.Length;
			textBox.Text = textBox.SelectedText;*/
			textBox.SelectAll();
			textBox.Focus();
		}
		void TextBoxClick(object sender, EventArgs e)
		{
			textBox.SelectAll();
			textBox.Focus();
		}
	}
}

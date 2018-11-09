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
		Bitmap pict, new_pict;
		int red, green, blue;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			red = trackBarRed.Value;
			green = trackBarGreen.Value;
			blue = trackBarBlue.Value;
			textBoxBlue.Text = blue.ToString();
			textBoxGreen.Text = green.ToString();
			textBoxRed.Text = red.ToString();
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
		void BtnOpenClick(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Pictures|*.bmp;*.png;*.jpg;*.jpeg;*.ico|All files|*.*";
			openFileDialog1.FileName = "";
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try {
					pict = new Bitmap(openFileDialog1.FileName);
				} catch (Exception) {
					
					MessageBox.Show("Неверный тип файла");
				}
				
				pictureBox.Image = pict;
				btnConvert.Enabled = true;
				new_pict = new Bitmap(pict.Width, pict.Height);
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
							if((pixel.R <= red) && (pixel.G <= green) && (pixel.B <= blue))
							{
								segment = SetBit(segment, 7-k, true);
								new_pict.SetPixel(i+k, j, Color.Black);
							}
							else
								new_pict.SetPixel(i+k, j, Color.White);
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
			pictureBox1.Image = new_pict;
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Кодировщик картинок версия 2\n" +
			                "Конвертирует картинки в бинарный формат\n"+
			                "Нулевой байт в массиве - высота в битах, второй - ширина в байтах\n"+
			               	"Отрисовку начинать с четвертого байта");
		}
		void TextBoxTextChanged(object sender, EventArgs e)
		{
			textBox.SelectAll();
			textBox.Focus();
		}
		void TextBoxClick(object sender, EventArgs e)
		{
			textBox.SelectAll();
			textBox.Focus();
		}
		void TrackBarRedScroll(object sender, EventArgs e)
		{
			red = trackBarRed.Value;
			textBoxRed.Text = red.ToString();
		}
		void TrackBarGreenScroll(object sender, EventArgs e)
		{
			green = trackBarGreen.Value;
			textBoxGreen.Text = green.ToString();
		}
		void TrackBarBlueScroll(object sender, EventArgs e)
		{
			blue = trackBarBlue.Value;
			textBoxBlue.Text = blue.ToString();
		}
		void TextBoxRedTextChanged(object sender, EventArgs e)
		{
			try 
			{
				red = Convert.ToInt32(textBoxRed.Text);
				if(red > 255)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					red = 255;
				}
				if(red < 0)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					red = 0;
				}
				trackBarRed.Value = red;
			} 
			catch (Exception) 
			{	
				MessageBox.Show("Неверный формат ввода");
			}
		}
		void TextBoxGreenTextChanged(object sender, EventArgs e)
		{
			try 
			{
				green = Convert.ToInt32(textBoxGreen.Text);
				if(green > 255)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					green = 255;
				}
				if(green < 0)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					green = 0;
				}
				trackBarGreen.Value = green;
			} 
			catch (Exception) 
			{
				MessageBox.Show("Неверный формат ввода");
			}
		}
		void TextBoxBlueTextChanged(object sender, EventArgs e)
		{
			try 
			{
				blue = Convert.ToInt32(textBoxBlue.Text);
				if(blue > 255)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					blue = 255;
				}
				if(blue < 0)
				{
					MessageBox.Show("Диапазон вводимых занчений 0-255");
					blue = 0;
				}
				trackBarBlue.Value = blue;
			} 
			catch (Exception) 
			{
				MessageBox.Show("Неверный формат ввода");
			}
		}
		void ConverRowClick(object sender, EventArgs e)
		{
			textBox.Clear();
			int width = pict.Width;
			int height = pict.Height;
			byte segment = 0;
			string line = "";
			Color pixel;
			int height_byte = pict.Height/8;
			if(pict.Height%8 != 0)
			{
				height_byte++;
			}
			
			for(int i = 0; i < width; i++)
			{
				for(int j = 0; j < height_byte; j+=8)
				{
					segment = 0;
					for(int k = 0; k < 8; k++)
					{
						try 
						{
							pixel = pict.GetPixel(i,j + k);
							if((pixel.R <= red) && (pixel.G <= green) && (pixel.B <= blue))
							{
								segment = SetBit(segment, 7-k, true);
								new_pict.SetPixel(i+k, j, Color.Black);
							}
							else
								new_pict.SetPixel(i, j+k, Color.White);
						} 
						catch (Exception) 
						{
							break;
						}
						line += "0x"+Convert.ToString(segment, 16)+",";
					}
					line += Environment.NewLine;
				}
				textBox.Text += line;
				pictureBox1.Image = new_pict;
			}
		}
	}
}

/*
 * Создано в SharpDevelop.
 * Пользователь: KAMIAK
 * Дата: 17.07.2018
 * Время: 14:22
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
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
//			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
//			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			red = trackBarRed.Value;
			green = trackBarGreen.Value;
			blue = trackBarBlue.Value;
			textBoxBlue.Text = blue.ToString();
			textBoxGreen.Text = green.ToString();
			textBoxRed.Text = red.ToString();
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
			textBox.Clear();
			
			var width = (Int16)pict.Width;
			var height = (Int16)pict.Height;
			String line, buf;
			byte buf_byte;
			
			//записываем ширину в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(width & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line = buf;
			buf_byte = Convert.ToByte((width & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			//записываем высоту в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(height & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			buf_byte = Convert.ToByte((height & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			byte segment;
			
			textBox.AppendText(line + Environment.NewLine);
			
			for(int j = 0; j < height; j++)
			{
				line = "";
				for(int i = 0; i < width; i+=8)
				{
					segment = 0;
					
					try 
					{
						for (int k = 0; k < 8; k++) 
						{
							Color pixel = pict.GetPixel(i + k, j);
							
							if((pixel.R <= red) && (pixel.B <= blue) && (pixel.G <= green))
							{
								segment = Functions.SetBit(segment, 7 - k, true);
								new_pict.SetPixel(i + k, j, Color.Black);
							}
							else
								new_pict.SetPixel(i + k, j, Color.White);
						}
						
					} 
					catch (Exception) 
					{
						line += Functions.GetHexNumber(segment) + ",";
						break;						
					}
					line += Functions.GetHexNumber(segment) + ",";					
				}
				textBox.AppendText(line + Environment.NewLine);
			}
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
		void BtnConvertRowClick(object sender, EventArgs e)
		{
			textBox.Clear();
			
			var width = (Int16)pict.Width;
			var height = (Int16)pict.Height;
			String line, buf;
			byte buf_byte;
			
			//записываем ширину в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(width & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line = buf;
			buf_byte = Convert.ToByte((width & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			//записываем высоту в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(height & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			buf_byte = Convert.ToByte((height & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			textBox.AppendText(line + Environment.NewLine);
			
			byte segment = 0;
						
			for(int i = 0; i < width; i++)
			{
				line = "";
				for(int j = 0; j < height; j+=8)
				{
					segment = 0;
					try 
					{
						for(int k = 0; k < 8; k++)
						{
							Color pixel = pict.GetPixel(i, j + k);
							
							if((pixel.R <= red) && (pixel.B <= blue) && (pixel.G <= green))
							{
								segment = Functions.SetBit(segment, 7 - k, true);
								new_pict.SetPixel(i, j + k, Color.Black);
							}
							else
								new_pict.SetPixel(i, j + k, Color.White);
						}
					} 
					catch (Exception)
					{
						line += Functions.GetHexNumber(segment) + ",";
						break;
					}
					line += Functions.GetHexNumber(segment) + ",";
				}
				textBox.AppendText(line + Environment.NewLine);
			}
			pictureBox1.Image = new_pict;
		}
		void BtnConverRow8Click(object sender, EventArgs e)
		{
			textBox.Clear();
			
			int width = pict.Width;
			int height = pict.Height;
			String line, buf;
			byte buf_byte;
			
			//записываем ширину в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(width & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line = buf;
			buf_byte = Convert.ToByte((width & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			//записываем высоту в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(height & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			buf_byte = Convert.ToByte((height & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			textBox.AppendText(line + Environment.NewLine);
			
			byte segment = 0;
			
			for(int j = 0; j < height; j+=8)
			{
				line = "";
				for(int i = 0; i < width; i++)
				{
					segment = 0;
					
					try 
					{
						for(int k = 0; k < 8; k++)
						{
							Color pixel = pict.GetPixel(i, j + k);
							
							if((pixel.R <= red) && (pixel.B <= blue) && (pixel.G <= green))
							{
								segment = Functions.SetBit(segment, 7 - k, true);
								new_pict.SetPixel(i, j + k, Color.Black);
							}
							else
								new_pict.SetPixel(i, j + k, Color.White);
							
						}
					} 
					catch (Exception) 
					{
						line += Functions.GetHexNumber(segment) + ",";
						continue;
					}
					line += Functions.GetHexNumber(segment) + ",";
				}
				textBox.AppendText(line + Environment.NewLine);
			}
			pictureBox1.Image = new_pict;
		}
		void BtnConvertSKBClick(object sender, EventArgs e)
		{
			textBox.Clear();
			
			int width = pict.Width;
			int height = pict.Height;
			String line, buf;
			byte buf_byte;
			
			//записываем ширину в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(width & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line = buf;
			buf_byte = Convert.ToByte((width & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			//записываем высоту в битах, сразу младшая часть,
			buf_byte = Convert.ToByte(height & 0x00FF);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			buf_byte = Convert.ToByte((height & 0xFF00)>>8);
			buf = Functions.GetHexNumber(buf_byte) + ",";
			line += buf;
			
			textBox.AppendText(line + Environment.NewLine);
			
			byte segment = 0;
			
			for(int j = 0; j < height; j+=8)
			{
				line = "";
				for(int i = 0; i < width; i++)
				{
					segment = 0;
					
					try 
					{
						for(int k = 0; k < 8; k++)
						{
							Color pixel = pict.GetPixel(i, j + k);
							
							if((pixel.R <= red) && (pixel.B <= blue) && (pixel.G <= green))
							{
								segment = Functions.SetBit(segment, k, true);
								new_pict.SetPixel(i, j + k, Color.Black);
							}
							else
								new_pict.SetPixel(i, j + k, Color.White);
							
						}
					} 
					catch (Exception) 
					{
						line += Functions.GetHexNumber(segment) + ",";
						continue;
					}
					line += Functions.GetHexNumber(segment) + ",";
				}
				textBox.AppendText(line + Environment.NewLine);
			}
			pictureBox1.Image = new_pict;
		}
	}
}
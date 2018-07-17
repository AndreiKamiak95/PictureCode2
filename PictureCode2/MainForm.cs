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
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnOpenClick(object sender, EventArgs e)
		{
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
			
			if(width%8 != 0)
			{
				width++;
			}
			//textBox.Text +=
		}
	}
}

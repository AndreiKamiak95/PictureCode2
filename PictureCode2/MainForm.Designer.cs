/*
 * Создано в SharpDevelop.
 * Пользователь: KAMIAK
 * Дата: 17.07.2018
 * Время: 14:22
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace PictureCode2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 215);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// btnConvert
			// 
			this.btnConvert.Enabled = false;
			this.btnConvert.Location = new System.Drawing.Point(93, 215);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(75, 23);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.BtnConvertClick);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 27);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(156, 182);
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(175, 27);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.Size = new System.Drawing.Size(434, 316);
			this.textBox.TabIndex = 3;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exitToolStripMenuItem,
			this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(621, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 355);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "PictureCode2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

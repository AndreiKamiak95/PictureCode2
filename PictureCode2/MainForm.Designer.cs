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
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TrackBar trackBarRed;
		private System.Windows.Forms.TrackBar trackBarGreen;
		private System.Windows.Forms.TrackBar trackBarBlue;
		private System.Windows.Forms.TextBox textBoxRed;
		private System.Windows.Forms.TextBox textBoxGreen;
		private System.Windows.Forms.TextBox textBoxBlue;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnConvertRow;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trackBarRed = new System.Windows.Forms.TrackBar();
			this.trackBarGreen = new System.Windows.Forms.TrackBar();
			this.trackBarBlue = new System.Windows.Forms.TrackBar();
			this.textBoxRed = new System.Windows.Forms.TextBox();
			this.textBoxGreen = new System.Windows.Forms.TextBox();
			this.textBoxBlue = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnConvertRow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(165, 182);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(41, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(212, 182);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(52, 23);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.BtnConvertClick);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(165, 27);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(198, 149);
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(369, 27);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.Size = new System.Drawing.Size(434, 333);
			this.textBox.TabIndex = 3;
			this.textBox.Click += new System.EventHandler(this.TextBoxClick);
			this.textBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(815, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// trackBarRed
			// 
			this.trackBarRed.BackColor = System.Drawing.Color.Red;
			this.trackBarRed.Location = new System.Drawing.Point(12, 27);
			this.trackBarRed.Maximum = 255;
			this.trackBarRed.Name = "trackBarRed";
			this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarRed.Size = new System.Drawing.Size(45, 307);
			this.trackBarRed.TabIndex = 5;
			this.trackBarRed.Value = 230;
			this.trackBarRed.Scroll += new System.EventHandler(this.TrackBarRedScroll);
			// 
			// trackBarGreen
			// 
			this.trackBarGreen.BackColor = System.Drawing.Color.Green;
			this.trackBarGreen.Location = new System.Drawing.Point(63, 27);
			this.trackBarGreen.Maximum = 255;
			this.trackBarGreen.Name = "trackBarGreen";
			this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarGreen.Size = new System.Drawing.Size(45, 307);
			this.trackBarGreen.TabIndex = 6;
			this.trackBarGreen.Value = 230;
			this.trackBarGreen.Scroll += new System.EventHandler(this.TrackBarGreenScroll);
			// 
			// trackBarBlue
			// 
			this.trackBarBlue.BackColor = System.Drawing.Color.Blue;
			this.trackBarBlue.Location = new System.Drawing.Point(114, 27);
			this.trackBarBlue.Maximum = 255;
			this.trackBarBlue.Name = "trackBarBlue";
			this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarBlue.Size = new System.Drawing.Size(45, 307);
			this.trackBarBlue.TabIndex = 7;
			this.trackBarBlue.Value = 230;
			this.trackBarBlue.Scroll += new System.EventHandler(this.TrackBarBlueScroll);
			// 
			// textBoxRed
			// 
			this.textBoxRed.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxRed.Location = new System.Drawing.Point(12, 341);
			this.textBoxRed.Name = "textBoxRed";
			this.textBoxRed.Size = new System.Drawing.Size(45, 20);
			this.textBoxRed.TabIndex = 8;
			this.textBoxRed.TextChanged += new System.EventHandler(this.TextBoxRedTextChanged);
			// 
			// textBoxGreen
			// 
			this.textBoxGreen.Location = new System.Drawing.Point(63, 341);
			this.textBoxGreen.Name = "textBoxGreen";
			this.textBoxGreen.Size = new System.Drawing.Size(45, 20);
			this.textBoxGreen.TabIndex = 9;
			this.textBoxGreen.TextChanged += new System.EventHandler(this.TextBoxGreenTextChanged);
			// 
			// textBoxBlue
			// 
			this.textBoxBlue.Location = new System.Drawing.Point(114, 340);
			this.textBoxBlue.Name = "textBoxBlue";
			this.textBoxBlue.Size = new System.Drawing.Size(45, 20);
			this.textBoxBlue.TabIndex = 10;
			this.textBoxBlue.TextChanged += new System.EventHandler(this.TextBoxBlueTextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(165, 211);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(198, 150);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// btnConvertRow
			// 
			this.btnConvertRow.Location = new System.Drawing.Point(270, 182);
			this.btnConvertRow.Name = "btnConvertRow";
			this.btnConvertRow.Size = new System.Drawing.Size(80, 23);
			this.btnConvertRow.TabIndex = 12;
			this.btnConvertRow.Text = "ConvertRow";
			this.btnConvertRow.UseVisualStyleBackColor = true;
			this.btnConvertRow.Click += new System.EventHandler(this.BtnConvertRowClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 373);
			this.Controls.Add(this.btnConvertRow);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxBlue);
			this.Controls.Add(this.textBoxGreen);
			this.Controls.Add(this.textBoxRed);
			this.Controls.Add(this.trackBarBlue);
			this.Controls.Add(this.trackBarGreen);
			this.Controls.Add(this.trackBarRed);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "PictureCode2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

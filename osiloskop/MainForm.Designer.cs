/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: musta
 * Tarih: 18.01.2017
 * Zaman: 16:21
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace osiloskop
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(202, 554);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1127, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "-------------------------------------";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(202, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1127, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "++++++++++++++++++++++++++++++";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(81, 27);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(98, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Value = 5;
			this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 28);
			this.label3.TabIndex = 3;
			this.label3.Text = "V(volt)";
			// 
			// trackBar2
			// 
			this.trackBar2.LargeChange = 1;
			this.trackBar2.Location = new System.Drawing.Point(81, 95);
			this.trackBar2.Maximum = 100;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(98, 45);
			this.trackBar2.TabIndex = 4;
			this.trackBar2.Value = 3;
			this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2Scroll);
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.radioButton1.Location = new System.Drawing.Point(141, 281);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(38, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "-e";
			this.radioButton1.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 28);
			this.label4.TabIndex = 6;
			this.label4.Text = "g->";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(22, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 35);
			this.label5.TabIndex = 7;
			this.label5.Text = "lbl5";
			// 
			// trackBar3
			// 
			this.trackBar3.LargeChange = 1;
			this.trackBar3.Location = new System.Drawing.Point(81, 195);
			this.trackBar3.Maximum = 100;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(98, 45);
			this.trackBar3.TabIndex = 8;
			this.trackBar3.Value = 3;
			this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3Scroll);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 45);
			this.label6.TabIndex = 9;
			this.label6.Text = "yatay hız";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1367, 616);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.trackBar3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "osiloskop";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		

		
	}
}

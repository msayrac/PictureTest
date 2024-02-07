namespace PictureTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnRenk = new System.Windows.Forms.Button();
			this.BtnResimSec = new System.Windows.Forms.Button();
			this.BtnYazdir = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtMetin = new System.Windows.Forms.TextBox();
			this.TxtBoyut = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnRenk
			// 
			this.BtnRenk.Location = new System.Drawing.Point(130, 100);
			this.BtnRenk.Name = "BtnRenk";
			this.BtnRenk.Size = new System.Drawing.Size(149, 36);
			this.BtnRenk.TabIndex = 2;
			this.BtnRenk.Text = "Renk Seç";
			this.BtnRenk.UseVisualStyleBackColor = true;
			this.BtnRenk.Click += new System.EventHandler(this.BtnRenk_Click);
			// 
			// BtnResimSec
			// 
			this.BtnResimSec.Location = new System.Drawing.Point(130, 45);
			this.BtnResimSec.Name = "BtnResimSec";
			this.BtnResimSec.Size = new System.Drawing.Size(149, 36);
			this.BtnResimSec.TabIndex = 1;
			this.BtnResimSec.Text = "Resim Seç";
			this.BtnResimSec.UseVisualStyleBackColor = true;
			this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
			// 
			// BtnYazdir
			// 
			this.BtnYazdir.Location = new System.Drawing.Point(130, 156);
			this.BtnYazdir.Name = "BtnYazdir";
			this.BtnYazdir.Size = new System.Drawing.Size(149, 36);
			this.BtnYazdir.TabIndex = 3;
			this.BtnYazdir.Text = "Yazdır";
			this.BtnYazdir.UseVisualStyleBackColor = true;
			this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(130, 208);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(149, 36);
			this.btnKaydet.TabIndex = 4;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Metnin:";
			// 
			// TxtMetin
			// 
			this.TxtMetin.Location = new System.Drawing.Point(125, 258);
			this.TxtMetin.Name = "TxtMetin";
			this.TxtMetin.Size = new System.Drawing.Size(154, 30);
			this.TxtMetin.TabIndex = 5;
			// 
			// TxtBoyut
			// 
			this.TxtBoyut.Location = new System.Drawing.Point(125, 311);
			this.TxtBoyut.Name = "TxtBoyut";
			this.TxtBoyut.Size = new System.Drawing.Size(154, 30);
			this.TxtBoyut.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 311);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Boyut:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(311, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(754, 333);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnKaydet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 470);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TxtBoyut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtMetin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.BtnYazdir);
			this.Controls.Add(this.BtnResimSec);
			this.Controls.Add(this.BtnRenk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnRenk;
		private System.Windows.Forms.Button BtnResimSec;
		private System.Windows.Forms.Button BtnYazdir;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtMetin;
		private System.Windows.Forms.TextBox TxtBoyut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}


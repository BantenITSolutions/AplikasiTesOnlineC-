/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
{
	partial class tambahSoal
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
			this.nKat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nPel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.noSoal = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.kunci = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnTmbh = new System.Windows.Forms.Button();
			this.jwbD = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.jwbC = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.jwbB = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.jwbA = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.inSoal = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nKat
			// 
			this.nKat.Location = new System.Drawing.Point(118, 12);
			this.nKat.Name = "nKat";
			this.nKat.ReadOnly = true;
			this.nKat.Size = new System.Drawing.Size(237, 20);
			this.nKat.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategori Soal :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mata Pelajaran :";
			// 
			// nPel
			// 
			this.nPel.Location = new System.Drawing.Point(118, 38);
			this.nPel.Name = "nPel";
			this.nPel.ReadOnly = true;
			this.nPel.Size = new System.Drawing.Size(237, 20);
			this.nPel.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(361, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nomor Soal :";
			// 
			// noSoal
			// 
			this.noSoal.Location = new System.Drawing.Point(444, 12);
			this.noSoal.Name = "noSoal";
			this.noSoal.ReadOnly = true;
			this.noSoal.Size = new System.Drawing.Size(64, 20);
			this.noSoal.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.kunci);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnTmbh);
			this.groupBox1.Controls.Add(this.jwbD);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.jwbC);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.jwbB);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.jwbA);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.inSoal);
			this.groupBox1.Location = new System.Drawing.Point(12, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 185);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input Soal";
			// 
			// kunci
			// 
			this.kunci.FormattingEnabled = true;
			this.kunci.Items.AddRange(new object[] {
									"A",
									"B",
									"C",
									"D"});
			this.kunci.Location = new System.Drawing.Point(111, 150);
			this.kunci.Name = "kunci";
			this.kunci.Size = new System.Drawing.Size(121, 21);
			this.kunci.TabIndex = 18;
			this.kunci.SelectedIndexChanged += new System.EventHandler(this.KunciSelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 153);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Kunci Jawaban :";
			// 
			// btnTmbh
			// 
			this.btnTmbh.Enabled = false;
			this.btnTmbh.Location = new System.Drawing.Point(364, 148);
			this.btnTmbh.Name = "btnTmbh";
			this.btnTmbh.Size = new System.Drawing.Size(126, 31);
			this.btnTmbh.TabIndex = 16;
			this.btnTmbh.Text = "Tambah Soal";
			this.btnTmbh.UseVisualStyleBackColor = true;
			this.btnTmbh.Click += new System.EventHandler(this.BtnTmbhClick);
			// 
			// jwbD
			// 
			this.jwbD.Location = new System.Drawing.Point(332, 122);
			this.jwbD.Name = "jwbD";
			this.jwbD.Size = new System.Drawing.Size(146, 20);
			this.jwbD.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(252, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Jawaban D :";
			// 
			// jwbC
			// 
			this.jwbC.Location = new System.Drawing.Point(86, 123);
			this.jwbC.Name = "jwbC";
			this.jwbC.Size = new System.Drawing.Size(146, 20);
			this.jwbC.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Jawaban C :";
			// 
			// jwbB
			// 
			this.jwbB.Location = new System.Drawing.Point(332, 94);
			this.jwbB.Name = "jwbB";
			this.jwbB.Size = new System.Drawing.Size(146, 20);
			this.jwbB.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(252, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Jawaban B :";
			// 
			// jwbA
			// 
			this.jwbA.Location = new System.Drawing.Point(86, 95);
			this.jwbA.Name = "jwbA";
			this.jwbA.Size = new System.Drawing.Size(146, 20);
			this.jwbA.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Jawaban A :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Pertanyaan :";
			// 
			// inSoal
			// 
			this.inSoal.Location = new System.Drawing.Point(86, 20);
			this.inSoal.Multiline = true;
			this.inSoal.Name = "inSoal";
			this.inSoal.Size = new System.Drawing.Size(404, 69);
			this.inSoal.TabIndex = 0;
			this.inSoal.TextChanged += new System.EventHandler(this.InSoalTextChanged);
			// 
			// tambahSoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 262);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.noSoal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nPel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nKat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "tambahSoal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tambahSoal";
			this.Load += new System.EventHandler(this.TambahSoalLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox kunci;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnTmbh;
		private System.Windows.Forms.TextBox jwbD;
		private System.Windows.Forms.TextBox jwbC;
		private System.Windows.Forms.TextBox jwbB;
		private System.Windows.Forms.TextBox jwbA;
		private System.Windows.Forms.TextBox inSoal;
		private System.Windows.Forms.TextBox nKat;
		private System.Windows.Forms.TextBox nPel;
		private System.Windows.Forms.TextBox noSoal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

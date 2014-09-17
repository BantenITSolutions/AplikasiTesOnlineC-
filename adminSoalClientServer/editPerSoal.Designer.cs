/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
{
	partial class editPerSoal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editPerSoal));
			this.label1 = new System.Windows.Forms.Label();
			this.soalPertanyaan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.jwb_a = new System.Windows.Forms.TextBox();
			this.jwb_b = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.jwb_c = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.jwb_d = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbKunci = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pertanyaan :";
			// 
			// soalPertanyaan
			// 
			this.soalPertanyaan.Location = new System.Drawing.Point(93, 9);
			this.soalPertanyaan.Multiline = true;
			this.soalPertanyaan.Name = "soalPertanyaan";
			this.soalPertanyaan.Size = new System.Drawing.Size(358, 72);
			this.soalPertanyaan.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Jawaban A :";
			// 
			// jwb_a
			// 
			this.jwb_a.Location = new System.Drawing.Point(93, 87);
			this.jwb_a.Name = "jwb_a";
			this.jwb_a.Size = new System.Drawing.Size(358, 20);
			this.jwb_a.TabIndex = 3;
			// 
			// jwb_b
			// 
			this.jwb_b.Location = new System.Drawing.Point(93, 113);
			this.jwb_b.Name = "jwb_b";
			this.jwb_b.Size = new System.Drawing.Size(358, 20);
			this.jwb_b.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Jawaban B :";
			// 
			// jwb_c
			// 
			this.jwb_c.Location = new System.Drawing.Point(93, 139);
			this.jwb_c.Name = "jwb_c";
			this.jwb_c.Size = new System.Drawing.Size(358, 20);
			this.jwb_c.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Jawaban C :";
			// 
			// jwb_d
			// 
			this.jwb_d.Location = new System.Drawing.Point(93, 165);
			this.jwb_d.Name = "jwb_d";
			this.jwb_d.Size = new System.Drawing.Size(358, 20);
			this.jwb_d.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Jawaban D :";
			// 
			// cmbKunci
			// 
			this.cmbKunci.FormattingEnabled = true;
			this.cmbKunci.Items.AddRange(new object[] {
									"A",
									"B",
									"C",
									"D"});
			this.cmbKunci.Location = new System.Drawing.Point(93, 191);
			this.cmbKunci.Name = "cmbKunci";
			this.cmbKunci.Size = new System.Drawing.Size(121, 21);
			this.cmbKunci.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Kunci :";
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(93, 218);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(110, 37);
			this.button1.TabIndex = 12;
			this.button1.Text = "Simpan Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// editPerSoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 274);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbKunci);
			this.Controls.Add(this.jwb_d);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.jwb_c);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.jwb_b);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.jwb_a);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.soalPertanyaan);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "editPerSoal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "editPerSoal";
			this.Load += new System.EventHandler(this.EditPerSoalLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cmbKunci;
		private System.Windows.Forms.TextBox jwb_d;
		private System.Windows.Forms.TextBox jwb_c;
		private System.Windows.Forms.TextBox jwb_b;
		private System.Windows.Forms.TextBox jwb_a;
		private System.Windows.Forms.TextBox soalPertanyaan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

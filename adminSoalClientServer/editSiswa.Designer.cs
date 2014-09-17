/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 9:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
{
	partial class editSiswa
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
			this.label1 = new System.Windows.Forms.Label();
			this.nInduk = new System.Windows.Forms.TextBox();
			this.nSiswa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lahir = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.almt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.passLama = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.passBaru = new System.Windows.Forms.TextBox();
			this.ulangPass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.inPasLama = new System.Windows.Forms.Label();
			this.inPasBaru = new System.Windows.Forms.Label();
			this.inUlangPass = new System.Windows.Forms.Label();
			this.ubhPass = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "No Induk :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nInduk
			// 
			this.nInduk.Location = new System.Drawing.Point(96, 12);
			this.nInduk.Name = "nInduk";
			this.nInduk.ReadOnly = true;
			this.nInduk.Size = new System.Drawing.Size(221, 20);
			this.nInduk.TabIndex = 1;
			// 
			// nSiswa
			// 
			this.nSiswa.Location = new System.Drawing.Point(96, 38);
			this.nSiswa.Name = "nSiswa";
			this.nSiswa.Size = new System.Drawing.Size(221, 20);
			this.nSiswa.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nama Siswa :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lahir
			// 
			this.lahir.Location = new System.Drawing.Point(96, 64);
			this.lahir.Name = "lahir";
			this.lahir.Size = new System.Drawing.Size(221, 20);
			this.lahir.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kelahiran :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// almt
			// 
			this.almt.Location = new System.Drawing.Point(96, 90);
			this.almt.Name = "almt";
			this.almt.Size = new System.Drawing.Size(221, 20);
			this.almt.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Alamat :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// passLama
			// 
			this.passLama.Location = new System.Drawing.Point(141, 144);
			this.passLama.Name = "passLama";
			this.passLama.ReadOnly = true;
			this.passLama.Size = new System.Drawing.Size(176, 20);
			this.passLama.TabIndex = 9;
			this.passLama.TextChanged += new System.EventHandler(this.PassLamaTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Password Lama :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSimpan
			// 
			this.btnSimpan.Location = new System.Drawing.Point(213, 222);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(104, 40);
			this.btnSimpan.TabIndex = 10;
			this.btnSimpan.Text = "Simpan Data";
			this.btnSimpan.UseVisualStyleBackColor = true;
			this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Password Baru :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// passBaru
			// 
			this.passBaru.Location = new System.Drawing.Point(141, 170);
			this.passBaru.Name = "passBaru";
			this.passBaru.ReadOnly = true;
			this.passBaru.Size = new System.Drawing.Size(176, 20);
			this.passBaru.TabIndex = 12;
			this.passBaru.TextChanged += new System.EventHandler(this.PassBaruTextChanged);
			// 
			// ulangPass
			// 
			this.ulangPass.Location = new System.Drawing.Point(141, 196);
			this.ulangPass.Name = "ulangPass";
			this.ulangPass.ReadOnly = true;
			this.ulangPass.Size = new System.Drawing.Size(176, 20);
			this.ulangPass.TabIndex = 14;
			this.ulangPass.TextChanged += new System.EventHandler(this.UlangPassTextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 194);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Ketik Ulang Password :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// inPasLama
			// 
			this.inPasLama.Location = new System.Drawing.Point(323, 144);
			this.inPasLama.Name = "inPasLama";
			this.inPasLama.Size = new System.Drawing.Size(32, 23);
			this.inPasLama.TabIndex = 15;
			this.inPasLama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// inPasBaru
			// 
			this.inPasBaru.Location = new System.Drawing.Point(323, 171);
			this.inPasBaru.Name = "inPasBaru";
			this.inPasBaru.Size = new System.Drawing.Size(77, 23);
			this.inPasBaru.TabIndex = 16;
			this.inPasBaru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// inUlangPass
			// 
			this.inUlangPass.Location = new System.Drawing.Point(323, 195);
			this.inUlangPass.Name = "inUlangPass";
			this.inUlangPass.Size = new System.Drawing.Size(32, 23);
			this.inUlangPass.TabIndex = 17;
			this.inUlangPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ubhPass
			// 
			this.ubhPass.Location = new System.Drawing.Point(96, 114);
			this.ubhPass.Name = "ubhPass";
			this.ubhPass.Size = new System.Drawing.Size(104, 24);
			this.ubhPass.TabIndex = 18;
			this.ubhPass.Text = "Ubah Password";
			this.ubhPass.UseVisualStyleBackColor = true;
			this.ubhPass.CheckedChanged += new System.EventHandler(this.UbhPassCheckedChanged);
			// 
			// editSiswa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 271);
			this.Controls.Add(this.ubhPass);
			this.Controls.Add(this.inUlangPass);
			this.Controls.Add(this.inPasBaru);
			this.Controls.Add(this.inPasLama);
			this.Controls.Add(this.ulangPass);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.passBaru);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.passLama);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.almt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lahir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nSiswa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nInduk);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "editSiswa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "editSiswa";
			this.Load += new System.EventHandler(this.EditSiswaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox ubhPass;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.TextBox passLama;
		private System.Windows.Forms.Label inUlangPass;
		private System.Windows.Forms.Label inPasBaru;
		private System.Windows.Forms.Label inPasLama;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ulangPass;
		private System.Windows.Forms.TextBox passBaru;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox almt;
		private System.Windows.Forms.TextBox lahir;
		private System.Windows.Forms.TextBox nSiswa;
		private System.Windows.Forms.TextBox nInduk;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

/*
 * Created by SharpDevelop.
 * User: LUMBUNG
 * Date: 30/01/2011
 * Time: 9:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soalClientServer
{
	partial class TesSoal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesSoal));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.alamatSiswa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.kelahiran = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.namaSiswa = new System.Windows.Forms.TextBox();
			this.noInduk = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.tampilSoalBelumTerjawab = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tampilSoalTerjawab = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tampilNoSoal = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.noSoal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.katSoal = new System.Windows.Forms.TextBox();
			this.matPel = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.jwbD = new System.Windows.Forms.RadioButton();
			this.jwbB = new System.Windows.Forms.RadioButton();
			this.jwbC = new System.Windows.Forms.RadioButton();
			this.jwbA = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.soalTampil = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSec = new System.Windows.Forms.TextBox();
			this.lblMin = new System.Windows.Forms.TextBox();
			this.lblHr = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.alamatSiswa);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.kelahiran);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.namaSiswa);
			this.groupBox1.Controls.Add(this.noInduk);
			this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(11, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 205);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detail Data Siswa";
			// 
			// alamatSiswa
			// 
			this.alamatSiswa.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alamatSiswa.Location = new System.Drawing.Point(7, 173);
			this.alamatSiswa.Name = "alamatSiswa";
			this.alamatSiswa.ReadOnly = true;
			this.alamatSiswa.Size = new System.Drawing.Size(187, 21);
			this.alamatSiswa.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(5, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Alamat Siswa :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Tempat, Tanggal Lahir :";
			// 
			// kelahiran
			// 
			this.kelahiran.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kelahiran.Location = new System.Drawing.Point(6, 129);
			this.kelahiran.Name = "kelahiran";
			this.kelahiran.ReadOnly = true;
			this.kelahiran.Size = new System.Drawing.Size(187, 21);
			this.kelahiran.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Nama Siswa :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nomor Induk :";
			// 
			// namaSiswa
			// 
			this.namaSiswa.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namaSiswa.Location = new System.Drawing.Point(6, 85);
			this.namaSiswa.Name = "namaSiswa";
			this.namaSiswa.ReadOnly = true;
			this.namaSiswa.Size = new System.Drawing.Size(187, 21);
			this.namaSiswa.TabIndex = 16;
			// 
			// noInduk
			// 
			this.noInduk.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noInduk.Location = new System.Drawing.Point(7, 41);
			this.noInduk.Name = "noInduk";
			this.noInduk.ReadOnly = true;
			this.noInduk.Size = new System.Drawing.Size(187, 21);
			this.noInduk.TabIndex = 15;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(760, 125);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.tampilSoalBelumTerjawab);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.tampilSoalTerjawab);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tampilNoSoal);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.groupBox5);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(12, 127);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 399);
			this.panel1.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(552, 77);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 20);
			this.label10.TabIndex = 28;
			this.label10.Text = "Soal belum terjawab :";
			// 
			// tampilSoalBelumTerjawab
			// 
			this.tampilSoalBelumTerjawab.Location = new System.Drawing.Point(660, 75);
			this.tampilSoalBelumTerjawab.Name = "tampilSoalBelumTerjawab";
			this.tampilSoalBelumTerjawab.ReadOnly = true;
			this.tampilSoalBelumTerjawab.Size = new System.Drawing.Size(77, 20);
			this.tampilSoalBelumTerjawab.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(369, 77);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 20);
			this.label9.TabIndex = 26;
			this.label9.Text = "Soal terjawab :";
			// 
			// tampilSoalTerjawab
			// 
			this.tampilSoalTerjawab.Location = new System.Drawing.Point(459, 75);
			this.tampilSoalTerjawab.Name = "tampilSoalTerjawab";
			this.tampilSoalTerjawab.ReadOnly = true;
			this.tampilSoalTerjawab.Size = new System.Drawing.Size(77, 20);
			this.tampilSoalTerjawab.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(217, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 20);
			this.label6.TabIndex = 24;
			this.label6.Text = "Soal ke :";
			// 
			// tampilNoSoal
			// 
			this.tampilNoSoal.Location = new System.Drawing.Point(281, 75);
			this.tampilNoSoal.Name = "tampilNoSoal";
			this.tampilNoSoal.ReadOnly = true;
			this.tampilNoSoal.Size = new System.Drawing.Size(77, 20);
			this.tampilNoSoal.TabIndex = 23;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(558, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 60);
			this.button2.TabIndex = 22;
			this.button2.Text = "Lewati Pertanyaan";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(655, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 60);
			this.button1.TabIndex = 21;
			this.button1.Text = "Pilih Jawaban";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.noSoal);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.katSoal);
			this.groupBox5.Controls.Add(this.matPel);
			this.groupBox5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.ForeColor = System.Drawing.Color.Black;
			this.groupBox5.Location = new System.Drawing.Point(11, 218);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(200, 169);
			this.groupBox5.TabIndex = 20;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Detail Soal Tes";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(5, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 17);
			this.label5.TabIndex = 19;
			this.label5.Text = "Nomor Soal :";
			// 
			// noSoal
			// 
			this.noSoal.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noSoal.Location = new System.Drawing.Point(7, 132);
			this.noSoal.Name = "noSoal";
			this.noSoal.ReadOnly = true;
			this.noSoal.Size = new System.Drawing.Size(186, 21);
			this.noSoal.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Kategori Soal :";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(115, 17);
			this.label8.TabIndex = 4;
			this.label8.Text = "Mata Pelajaran :";
			// 
			// katSoal
			// 
			this.katSoal.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.katSoal.Location = new System.Drawing.Point(6, 85);
			this.katSoal.Name = "katSoal";
			this.katSoal.ReadOnly = true;
			this.katSoal.Size = new System.Drawing.Size(187, 21);
			this.katSoal.TabIndex = 16;
			// 
			// matPel
			// 
			this.matPel.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matPel.Location = new System.Drawing.Point(7, 41);
			this.matPel.Name = "matPel";
			this.matPel.ReadOnly = true;
			this.matPel.Size = new System.Drawing.Size(187, 21);
			this.matPel.TabIndex = 15;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.jwbD);
			this.groupBox4.Controls.Add(this.jwbB);
			this.groupBox4.Controls.Add(this.jwbC);
			this.groupBox4.Controls.Add(this.jwbA);
			this.groupBox4.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Black;
			this.groupBox4.Location = new System.Drawing.Point(217, 257);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(528, 130);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Jawaban Soal Tes";
			// 
			// jwbD
			// 
			this.jwbD.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jwbD.Location = new System.Drawing.Point(13, 98);
			this.jwbD.Name = "jwbD";
			this.jwbD.Size = new System.Drawing.Size(493, 24);
			this.jwbD.TabIndex = 3;
			this.jwbD.TabStop = true;
			this.jwbD.UseVisualStyleBackColor = true;
			// 
			// jwbB
			// 
			this.jwbB.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jwbB.Location = new System.Drawing.Point(13, 48);
			this.jwbB.Name = "jwbB";
			this.jwbB.Size = new System.Drawing.Size(493, 24);
			this.jwbB.TabIndex = 2;
			this.jwbB.TabStop = true;
			this.jwbB.UseVisualStyleBackColor = true;
			// 
			// jwbC
			// 
			this.jwbC.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jwbC.Location = new System.Drawing.Point(13, 73);
			this.jwbC.Name = "jwbC";
			this.jwbC.Size = new System.Drawing.Size(493, 24);
			this.jwbC.TabIndex = 1;
			this.jwbC.TabStop = true;
			this.jwbC.UseVisualStyleBackColor = true;
			// 
			// jwbA
			// 
			this.jwbA.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jwbA.Location = new System.Drawing.Point(13, 22);
			this.jwbA.Name = "jwbA";
			this.jwbA.Size = new System.Drawing.Size(493, 24);
			this.jwbA.TabIndex = 0;
			this.jwbA.TabStop = true;
			this.jwbA.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.soalTampil);
			this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Black;
			this.groupBox3.Location = new System.Drawing.Point(217, 100);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(528, 156);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Soal Tes";
			// 
			// soalTampil
			// 
			this.soalTampil.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soalTampil.Location = new System.Drawing.Point(6, 17);
			this.soalTampil.Name = "soalTampil";
			this.soalTampil.Size = new System.Drawing.Size(516, 130);
			this.soalTampil.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.lblSec);
			this.groupBox2.Controls.Add(this.lblMin);
			this.groupBox2.Controls.Add(this.lblHr);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(217, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(335, 64);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Waktu Tes";
			// 
			// lblSec
			// 
			this.lblSec.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSec.Location = new System.Drawing.Point(235, 17);
			this.lblSec.Name = "lblSec";
			this.lblSec.ReadOnly = true;
			this.lblSec.Size = new System.Drawing.Size(87, 40);
			this.lblSec.TabIndex = 6;
			this.lblSec.Text = "00";
			this.lblSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblMin
			// 
			this.lblMin.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMin.Location = new System.Drawing.Point(123, 17);
			this.lblMin.Name = "lblMin";
			this.lblMin.ReadOnly = true;
			this.lblMin.Size = new System.Drawing.Size(87, 40);
			this.lblMin.TabIndex = 5;
			this.lblMin.Text = "00";
			this.lblMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblHr
			// 
			this.lblHr.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHr.Location = new System.Drawing.Point(12, 17);
			this.lblHr.Name = "lblHr";
			this.lblHr.ReadOnly = true;
			this.lblHr.Size = new System.Drawing.Size(87, 40);
			this.lblHr.TabIndex = 1;
			this.lblHr.Text = "00";
			this.lblHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(209, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(22, 40);
			this.label12.TabIndex = 4;
			this.label12.Text = ":";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(99, 17);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(22, 40);
			this.label11.TabIndex = 3;
			this.label11.Text = ":";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(-2, 529);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(791, 30);
			this.label13.TabIndex = 5;
			this.label13.Text = "Tes Soal Online Open Source 2011 - Simpel dan Gak Ribet";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// TesSoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TesSoal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TesSoal";
			this.Load += new System.EventHandler(this.TesSoalLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TesSoalFormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox tampilSoalTerjawab;
		private System.Windows.Forms.TextBox tampilSoalBelumTerjawab;
		private System.Windows.Forms.TextBox tampilNoSoal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox lblHr;
		private System.Windows.Forms.TextBox lblMin;
		private System.Windows.Forms.TextBox lblSec;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton jwbD;
		private System.Windows.Forms.RadioButton jwbB;
		private System.Windows.Forms.RadioButton jwbC;
		private System.Windows.Forms.RadioButton jwbA;
		private System.Windows.Forms.Label soalTampil;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox noSoal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox matPel;
		private System.Windows.Forms.TextBox katSoal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox noInduk;
		private System.Windows.Forms.TextBox namaSiswa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox kelahiran;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox alamatSiswa;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

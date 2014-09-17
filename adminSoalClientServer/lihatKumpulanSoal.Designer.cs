/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 10:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
{
	partial class lihatKumpulanSoal
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
			this.kumSoal = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.katSoal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.matPel = new System.Windows.Forms.TextBox();
			this.noSoal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.kumSoal)).BeginInit();
			this.SuspendLayout();
			// 
			// kumSoal
			// 
			this.kumSoal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kumSoal.Location = new System.Drawing.Point(8, 76);
			this.kumSoal.Name = "kumSoal";
			this.kumSoal.Size = new System.Drawing.Size(714, 198);
			this.kumSoal.TabIndex = 0;
			this.kumSoal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KumSoalCellContentClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategori Soal :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// katSoal
			// 
			this.katSoal.Location = new System.Drawing.Point(100, 12);
			this.katSoal.Name = "katSoal";
			this.katSoal.ReadOnly = true;
			this.katSoal.Size = new System.Drawing.Size(198, 20);
			this.katSoal.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(302, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mata Pelajaran :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// matPel
			// 
			this.matPel.Location = new System.Drawing.Point(396, 13);
			this.matPel.Name = "matPel";
			this.matPel.ReadOnly = true;
			this.matPel.Size = new System.Drawing.Size(198, 20);
			this.matPel.TabIndex = 4;
			// 
			// noSoal
			// 
			this.noSoal.Location = new System.Drawing.Point(668, 12);
			this.noSoal.Name = "noSoal";
			this.noSoal.ReadOnly = true;
			this.noSoal.Size = new System.Drawing.Size(54, 20);
			this.noSoal.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(605, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "No Soal :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(589, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 31);
			this.button1.TabIndex = 7;
			this.button1.Text = "Refresh Data Soal";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lihatKumpulanSoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(729, 287);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.noSoal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.matPel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.katSoal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kumSoal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "lihatKumpulanSoal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "lihatKumpulanSoal";
			this.Load += new System.EventHandler(this.LihatKumpulanSoalLoad);
			((System.ComponentModel.ISupportInitialize)(this.kumSoal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox katSoal;
		private System.Windows.Forms.TextBox matPel;
		private System.Windows.Forms.TextBox noSoal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView kumSoal;
	}
}

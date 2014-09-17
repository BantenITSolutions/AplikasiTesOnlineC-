/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 23:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
{
	partial class editKatMatPel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editKatMatPel));
			this.label1 = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.durasi = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama Label :";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(108, 9);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(185, 20);
			this.nama.TabIndex = 1;
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(12, 35);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(90, 23);
			this.label.TabIndex = 2;
			this.label.Text = "Durasi / Waktu :";
			// 
			// durasi
			// 
			this.durasi.Location = new System.Drawing.Point(108, 35);
			this.durasi.Name = "durasi";
			this.durasi.Size = new System.Drawing.Size(185, 20);
			this.durasi.TabIndex = 3;
			this.durasi.TextChanged += new System.EventHandler(this.DurasiTextChanged);
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(183, 61);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(110, 37);
			this.button1.TabIndex = 4;
			this.button1.Text = "Simpan Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// editKatMatPel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 109);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.durasi);
			this.Controls.Add(this.label);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "editKatMatPel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "editKatMatPel";
			this.Load += new System.EventHandler(this.EditKatMatPelLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox durasi;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Label label1;
	}
}

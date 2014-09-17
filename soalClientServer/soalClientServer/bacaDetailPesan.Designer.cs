/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 13/03/2011
 * Time: 12:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soalClientServer
{
	partial class bacaDetailPesan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bacaDetailPesan));
			this.btnBls = new System.Windows.Forms.Button();
			this.balasanAdmin = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.blsPsn = new System.Windows.Forms.CheckBox();
			this.pesanPengirim = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nmPengirim = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBls
			// 
			this.btnBls.Image = ((System.Drawing.Image)(resources.GetObject("btnBls.Image")));
			this.btnBls.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBls.Location = new System.Drawing.Point(405, 276);
			this.btnBls.Name = "btnBls";
			this.btnBls.Size = new System.Drawing.Size(91, 41);
			this.btnBls.TabIndex = 15;
			this.btnBls.Text = "Balas Pesan";
			this.btnBls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBls.UseVisualStyleBackColor = true;
			this.btnBls.Click += new System.EventHandler(this.BtnBlsClick);
			// 
			// balasanAdmin
			// 
			this.balasanAdmin.Location = new System.Drawing.Point(91, 172);
			this.balasanAdmin.Multiline = true;
			this.balasanAdmin.Name = "balasanAdmin";
			this.balasanAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.balasanAdmin.Size = new System.Drawing.Size(405, 98);
			this.balasanAdmin.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Balasan :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// blsPsn
			// 
			this.blsPsn.Location = new System.Drawing.Point(91, 142);
			this.blsPsn.Name = "blsPsn";
			this.blsPsn.Size = new System.Drawing.Size(104, 24);
			this.blsPsn.TabIndex = 12;
			this.blsPsn.Text = "Balas Pesan";
			this.blsPsn.UseVisualStyleBackColor = true;
			this.blsPsn.CheckedChanged += new System.EventHandler(this.BlsPsnCheckedChanged);
			// 
			// pesanPengirim
			// 
			this.pesanPengirim.Location = new System.Drawing.Point(91, 38);
			this.pesanPengirim.Multiline = true;
			this.pesanPengirim.Name = "pesanPengirim";
			this.pesanPengirim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.pesanPengirim.Size = new System.Drawing.Size(405, 98);
			this.pesanPengirim.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Pesan :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nmPengirim
			// 
			this.nmPengirim.Location = new System.Drawing.Point(91, 12);
			this.nmPengirim.Name = "nmPengirim";
			this.nmPengirim.Size = new System.Drawing.Size(320, 20);
			this.nmPengirim.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Pengirim :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bacaDetailPesan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 327);
			this.Controls.Add(this.btnBls);
			this.Controls.Add(this.balasanAdmin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.blsPsn);
			this.Controls.Add(this.pesanPengirim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nmPengirim);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "bacaDetailPesan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "bacaDetailPesan";
			this.Load += new System.EventHandler(this.BacaDetailPesanLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nmPengirim;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox pesanPengirim;
		private System.Windows.Forms.CheckBox blsPsn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox balasanAdmin;
		private System.Windows.Forms.Button btnBls;
	}
}

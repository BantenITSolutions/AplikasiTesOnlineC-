/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 09/03/2011
 * Time: 22:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace adminSoalClientServer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.usr = new System.Windows.Forms.TextBox();
			this.pwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 45);
			this.button1.TabIndex = 2;
			this.button1.Text = "Masuk";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// usr
			// 
			this.usr.Location = new System.Drawing.Point(94, 37);
			this.usr.Name = "usr";
			this.usr.Size = new System.Drawing.Size(157, 20);
			this.usr.TabIndex = 3;
			// 
			// pwd
			// 
			this.pwd.Location = new System.Drawing.Point(94, 63);
			this.pwd.Name = "pwd";
			this.pwd.Size = new System.Drawing.Size(157, 20);
			this.pwd.TabIndex = 4;
			this.pwd.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(264, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Log In Admin Soal Online";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Location = new System.Drawing.Point(0, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(264, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Soal Online @ 2011 - Gede Lumbung";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 170);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.usr);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log In Administrator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox pwd;
		private System.Windows.Forms.TextBox usr;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

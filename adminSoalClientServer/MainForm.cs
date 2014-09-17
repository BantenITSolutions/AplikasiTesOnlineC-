/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 09/03/2011
 * Time: 22:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace adminSoalClientServer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataTable tabel;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string user = usr.Text.ToString();
			string pass = pwd.Text.ToString();
			string nm_lengkap = "";
			Login masuk = new Login();
			tabel = masuk.ValidasiLogin(user,pass);
			
			foreach(DataRow kolom in tabel.Rows)
			{
				nm_lengkap = kolom["nama_lengkap"].ToString();
			}
			
			if (tabel.Rows.Count>0) {
				PanelAdmin f1 = new PanelAdmin();
				f1.nama = nm_lengkap;
				f1.Show();
				this.Hide();
			}
			else{
				MessageBox.Show("Password atau No Induk Tidak Ada Dalam Database!!!");
			}
		}
	}
}

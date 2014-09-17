/*
 * Created by SharpDevelop.
 * User: LUMBUNG
 * Date: 27/01/2011
 * Time: 16:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace soalClientServer
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
		
		void Button2Click(object sender, EventArgs e)
		{
			string user = usr.Text.ToString();
			string pass = psw.Text.ToString();
			string n_indk = "";
			string nama = ""; 
			string alamat = ""; 
			string lahir = "";
			string foto = "";
			Login masuk = new Login();
			tabel = masuk.ValidasiLogin(user,pass);
			
			foreach(DataRow kolom in tabel.Rows)
			{
				n_indk = kolom["no_induk"].ToString();
				nama = kolom["nama_siswa"].ToString();
				alamat = kolom["alamat"].ToString();
				lahir = kolom["kelahiran"].ToString();
				foto = kolom["foto"].ToString();
			}
			
			if (tabel.Rows.Count>0) {
				PanelUtama f1 = new PanelUtama();
				f1.no = n_indk;
				f1.nama = nama;
				f1.alamat = alamat;
				f1.lahir = lahir;
				f1.foto_usr = foto;
				f1.Show();
				this.Hide();
			}
			else{
				MessageBox.Show("Password atau No Induk Tidak Ada Dalam Database!!!");
			}
			
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			usr.Text = "";
			psw.Text = "";
		}
	}
}

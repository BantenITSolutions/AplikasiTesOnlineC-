/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 23:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace adminSoalClientServer
{
	public partial class editKatMatPel : Form
	{
		public string namaLabel;
		public string sts="";
		public int durasiWaktu,idLabel;
		public DataTable tabel;
		public editKatMatPel()
		{
			InitializeComponent();
		}
		
		void EditKatMatPelLoad(object sender, EventArgs e)
		{
			nama.Text = namaLabel;
			durasi.Text = durasiWaktu.ToString();
			if (sts=="pel") {
				durasi.Visible=true;
				label.Visible=true;
			}
			else{
				durasi.Visible=false;
				label.Visible=false;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (sts!="pel") {
				insertKatMatpel updt = new insertKatMatpel();
				tabel = updt.updateKat(nama.Text.ToString(),idLabel);
				MessageBox.Show("Data berhasil diperbaharui");
				this.Close();
			}
			else if(sts=="pel") {
				insertKatMatpel updt = new insertKatMatpel();
				tabel = updt.updateMat(nama.Text.ToString(),Convert.ToInt32(durasi.Text.ToString()),idLabel);
				MessageBox.Show("Data berhasil diperbaharui");
				this.Close();
			}
		}
		
		void DurasiTextChanged(object sender, EventArgs e)
		{
			try {
				int cek = Convert.ToInt32(durasi.Text.ToString());
			} catch (Exception) {
				MessageBox.Show("durasi harus merupakan angka");
				durasi.Text=durasiWaktu.ToString();
			}
		}
	}
}

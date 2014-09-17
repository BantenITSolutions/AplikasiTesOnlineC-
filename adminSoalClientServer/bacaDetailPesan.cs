/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 23:04
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
	/// <summary>
	/// Description of bacaDetailPesan.
	/// </summary>
	public partial class bacaDetailPesan : Form
	{
		public DataTable tabel;
		public int id_pesan,id_pengirim;
		public string n_siswa,psn;
		public bacaDetailPesan()
		{
			InitializeComponent();
		}
		
		void BacaDetailPesanLoad(object sender, EventArgs e)
		{
			nmPengirim.Text = n_siswa;
			pesanPengirim.Text = psn;
			balasanAdmin.Enabled=false;
			btnBls.Enabled=false;
			balasanAdmin.Text = "Reply from : ( "+psn+" ) ==> \n";
		}
		
		void BlsPsnCheckedChanged(object sender, EventArgs e)
		{
			if (blsPsn.Checked==true) {
				balasanAdmin.Enabled=true;
				balasanAdmin.Text = "Reply from : ( "+psn+" ) ==> \n";
				btnBls.Enabled=true;
			}
			else{
				balasanAdmin.Enabled=false;
				btnBls.Enabled=false;
			}
		}
		
		void BtnBlsClick(object sender, EventArgs e)
		{
			simpanPesan smpn = new simpanPesan();
			tabel = smpn.balasPesan(id_pengirim,balasanAdmin.Text.ToString());
			MessageBox.Show("Pesan terkirim");
			this.Close();
		}
	}
}

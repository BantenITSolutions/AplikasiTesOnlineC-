/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 13/03/2011
 * Time: 12:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	public partial class bacaDetailPesan : Form
	{
		public DataTable tabel;
		public int id_pesan;
		public string n_siswa,psn,id_pengirim;
		public bacaDetailPesan()
		{
			InitializeComponent();
		}
		
		void BacaDetailPesanLoad(object sender, EventArgs e)
		{
			nmPengirim.Text = id_pengirim;
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
			tabel = smpn.kirimPesan(n_siswa,balasanAdmin.Text.ToString());
			MessageBox.Show("Pesan terkirim");
			this.Close();
		}
	}
}

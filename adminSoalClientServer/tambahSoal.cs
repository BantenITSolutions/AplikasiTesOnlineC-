/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 10:21
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
	/// Description of tambahSoal.
	/// </summary>
	public partial class tambahSoal : Form
	{
		DataTable tabel;
		public int id_kat,id_matpel,no_soal;
		public string nama_matpel,nama_kat;
		public tambahSoal()
		{
			InitializeComponent();
		}
		
		void TambahSoalLoad(object sender, EventArgs e)
		{
			nKat.Text = nama_kat;
			nPel.Text = nama_matpel;
			noSoal.Text = no_soal.ToString();
		}
		
		void InSoalTextChanged(object sender, EventArgs e)
		{
			if (inSoal.Text!="" && kunci.Text!="") {
				btnTmbh.Enabled=true;
			}
			else{
				btnTmbh.Enabled=false;
			}
		}
		
		void KunciSelectedIndexChanged(object sender, EventArgs e)
		{
			if (inSoal.Text!="" && kunci.Text!="") {
				btnTmbh.Enabled=true;
			}
			else{
				btnTmbh.Enabled=false;
			}
		}
		
		void BtnTmbhClick(object sender, EventArgs e)
		{
			simpanDataSoal simpan = new simpanDataSoal();
			tabel = simpan.simpanSoal(no_soal,id_matpel,id_kat,inSoal.Text.ToString(),jwbA.Text.ToString(),jwbB.Text.ToString(),jwbC.Text.ToString(),jwbD.Text.ToString(),kunci.Text.ToLower());
			MessageBox.Show("Soal berhasil disimpan");
			inSoal.Text = "";
			jwbA.Text = "";
			jwbB.Text = "";
			jwbC.Text = "";
			jwbD.Text = "";
			kunci.Text = "";
		}
	}
}

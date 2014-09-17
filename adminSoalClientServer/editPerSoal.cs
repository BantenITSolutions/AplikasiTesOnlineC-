/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 18:00
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
	public partial class editPerSoal : Form
	{
		public DataTable tabel;
		public string pertanyaan,jwbA,jwbB,jwbC,jwbD,kunci;
		public int id_soal;
		
		public editPerSoal()
		{
			InitializeComponent();
		}
		
		void EditPerSoalLoad(object sender, EventArgs e)
		{
			soalPertanyaan.Text = pertanyaan;
			jwb_a.Text = jwbA;
			jwb_b.Text = jwbB;
			jwb_c.Text = jwbC;
			jwb_d.Text = jwbD;
			cmbKunci.Text = kunci;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			simpanDataSoal simpan = new simpanDataSoal();
			tabel = simpan.updateSoal(id_soal,soalPertanyaan.Text.ToString(),jwb_a.Text.ToString(),jwb_b.Text.ToString(),jwb_c.Text.ToString(),jwb_d.Text.ToString(),cmbKunci.Text.ToString());
			MessageBox.Show("Data berhasil diperbaharui");
			this.Close();
		}
	}
}

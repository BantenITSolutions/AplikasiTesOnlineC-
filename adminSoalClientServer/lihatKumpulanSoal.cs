/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 10:55
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
	public partial class lihatKumpulanSoal : Form
	{
		DataTable tabel;
		public int no_soal,id_kat,id_pel,id_soal;
		public string nama_kat,nama_pel;
		DataGridViewButtonColumn editSoal,hapusSoal;
		public lihatKumpulanSoal()
		{
			InitializeComponent();
		}
		
		void LihatKumpulanSoalLoad(object sender, EventArgs e)
		{
			katSoal.Text = nama_kat;
			matPel.Text = nama_pel;
			noSoal.Text = no_soal.ToString();
			tampilData();
		}
		
		public void tampilData()
		{
			bacaDataSoal baca = new bacaDataSoal();
			tabel = baca.bacaSoalTerseleksi(id_kat,no_soal,id_pel);
			kumSoal.DataSource = null;
			kumSoal.Columns.Clear();
			kumSoal.DataSource = tabel;
			kumSoal.AllowUserToAddRows = false;
			kumSoal.ReadOnly = true;
			kumSoal.Columns[0].HeaderText = "ID Soal";
			kumSoal.Columns[0].Width =70;
			kumSoal.Columns[1].HeaderText = "Pertanyaan";
			kumSoal.Columns[1].Width = 480;
			editSoal = new DataGridViewButtonColumn();
			editSoal.UseColumnTextForButtonValue = true;
			editSoal.Width=50;
			editSoal.Text = "Edit";
			kumSoal.Columns.Add(editSoal);
			hapusSoal = new DataGridViewButtonColumn();
			hapusSoal.UseColumnTextForButtonValue = true;
			hapusSoal.Width=50;
			hapusSoal.Text = "Hapus";
			kumSoal.Columns.Add(hapusSoal);
		}
		
		void KumSoalCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (kumSoal.Columns[e.ColumnIndex] == editSoal && currentRow >= 0) 
			{
				int id = Convert.ToInt32(kumSoal[0,currentRow].Value.ToString());
				bacaDataSoal baca = new bacaDataSoal();
				tabel = baca.pilihSoal(id);
				string jwbA="";
				string jwbB="";
				string jwbC="";
				string jwbD="";
				string pertanyaan="";
				string kunci  = "";
				foreach(DataRow kolom in tabel.Rows)
				{
					jwbA = kolom["jwb_a"].ToString();
					jwbB = kolom["jwb_b"].ToString();
					jwbC = kolom["jwb_c"].ToString();
					jwbD = kolom["jwb_d"].ToString();
					pertanyaan = kolom["pertanyaan"].ToString();
					kunci = kolom["kunci"].ToString();
				}
				editPerSoal f2 = new editPerSoal();
				f2.pertanyaan = pertanyaan;
				f2.jwbA = jwbA;
				f2.jwbB = jwbB;
				f2.jwbC = jwbC;
				f2.jwbD = jwbD;
				f2.kunci = kunci;
				f2.id_soal = id;
				f2.ShowDialog();
			}
			else if (kumSoal.Columns[e.ColumnIndex] == hapusSoal && currentRow >= 0) 
			{
				int id = Convert.ToInt32(kumSoal[0,currentRow].Value.ToString());
				hapusSoal hps = new hapusSoal();
				tabel = hps.hapusDataSoal(id);
				MessageBox.Show("Data berhasil dihapus");
				tampilData();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			tampilData();
		}
	}
}

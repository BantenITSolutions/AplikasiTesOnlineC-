/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 09/03/2011
 * Time: 22:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;

namespace adminSoalClientServer
{
	/// <summary>
	/// Description of PanelAdmin.
	/// </summary>
	public partial class PanelAdmin : Form
	{
		public string nama,status_export;
		public DataTable tabel;
		public DataGridViewButtonColumn editKategori, hapusKategori, editMatpel, hapusMatpel, editSiswa, hapusSiswa, editSoal, bacaPesan;
		public PanelAdmin()
		{
			InitializeComponent();
		}
		
		void PanelAdminFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void PanelAdminLoad(object sender, EventArgs e)
		{
			nmAdmin.Text = nama.ToString();
			KategoriSoal();
			MataPelajaran();
			DaftarSiswa();
		}
		
		public void DaftarSiswa()
		{
			bacaDataSiswa baca = new bacaDataSiswa();
			tabel = baca.lihatSemuaSiswa();
			foreach(DataRow kolom in tabel.Rows)
			{
				string id = kolom["no_induk"].ToString();
				string nm_kat = kolom["nama_siswa"].ToString();
				string gbng = ""+id+"-"+nm_kat+"";
				nmSiswa.Items.Add(gbng);
			}
			
		}
		
		public void KategoriSoal()
		{
			bacaKatMatpel kategori = new bacaKatMatpel();
			tabel = kategori.lihatSemuaKategori();
			foreach(DataRow kolom in tabel.Rows)
			{
				string id = kolom["id_kat"].ToString();
				string nm_kat = kolom["nama_kat"].ToString();
				string gbng = ""+id+"-"+nm_kat+"";
				cmbKategori.Items.Add(gbng);
				cmbKategori2.Items.Add(gbng);
				cmbKategori3.Items.Add(gbng);
			}
		}
		
		public void MataPelajaran()
		{
			bacaKatMatpel kategori = new bacaKatMatpel();
			tabel = kategori.lihatSemuaMatPel();
			foreach(DataRow kolom in tabel.Rows)
			{
				string id = kolom["id_pel"].ToString();
				string nm_kat = kolom["nama_pel"].ToString();
				string gbng = ""+id+"-"+nm_kat+"";
				cmbMataPelajaran.Items.Add(gbng);
				cmbMataPelajaran2.Items.Add(gbng);
				cmbMataPelajaran3.Items.Add(gbng);
			}
		}
		
		void NmKatBaruTextChanged(object sender, EventArgs e)
		{
			if (nmKatBaru.Text!="") 
			{
				simpanKat.Enabled = true;
			}
			else
			{
				simpanKat.Enabled = false;
			}
		}
		
		void NmMatPelBaruTextChanged(object sender, EventArgs e)
		{
			if (nmMatPelBaru.Text!="" && waktuBaru.Text!="") 
			{
				simpanMatpel.Enabled = true;
			}
			else
			{
				simpanMatpel.Enabled = false;
			}
		}
		
		void WaktuBaruTextChanged(object sender, EventArgs e)
		{
			if (nmMatPelBaru.Text!="" && waktuBaru.Text!="") 
			{
				try {
					int cek = Convert.ToInt32(waktuBaru.Text.ToString());
					simpanMatpel.Enabled = true;
				} catch (Exception) {
					MessageBox.Show("Input waktu harus merupakan angka...!!");
					waktuBaru.Text="";
				}
			}
			else
			{
				simpanMatpel.Enabled = false;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			bacaKatMatpel baca = new bacaKatMatpel();
			tabel = baca.lihatSemuaKategori();
			tampilKatMatpel.DataSource = null;
			tampilKatMatpel.Columns.Clear();
			tampilKatMatpel.DataSource = tabel;
			tampilKatMatpel.AllowUserToAddRows = false;
			tampilKatMatpel.ReadOnly = true;
			tampilKatMatpel.Columns[0].HeaderText = "No Kategori";
			tampilKatMatpel.Columns[0].Width = 125;
			tampilKatMatpel.Columns[1].HeaderText = "Nama Kategori";
			tampilKatMatpel.Columns[1].Width = 320;
			editKategori = new DataGridViewButtonColumn();
			editKategori.Width = 60;
			editKategori.UseColumnTextForButtonValue = true;
			editKategori.Text = "Edit";
			tampilKatMatpel.Columns.Add(editKategori);
			hapusKategori = new DataGridViewButtonColumn();
			hapusKategori.Width = 60;
			hapusKategori.UseColumnTextForButtonValue = true;
			hapusKategori.Text = "Hapus";
			tampilKatMatpel.Columns.Add(hapusKategori);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			bacaKatMatpel baca = new bacaKatMatpel();
			tabel = baca.lihatSemuaMatPel();
			tampilKatMatpel.DataSource = null;
			tampilKatMatpel.Columns.Clear();
			tampilKatMatpel.DataSource = tabel;
			tampilKatMatpel.AllowUserToAddRows = false;
			tampilKatMatpel.ReadOnly = true;
			tampilKatMatpel.Columns[0].HeaderText = "No Pelajaran";
			tampilKatMatpel.Columns[0].Width = 125;
			tampilKatMatpel.Columns[1].HeaderText = "Nama Pelajaran";
			tampilKatMatpel.Columns[1].Width = 200;
			tampilKatMatpel.Columns[2].HeaderText = "Durasi Waktu";
			tampilKatMatpel.Columns[2].Width = 120;
			editMatpel = new DataGridViewButtonColumn();
			editMatpel.Width = 60;
			editMatpel.UseColumnTextForButtonValue = true;
			editMatpel.Text = "Edit";
			tampilKatMatpel.Columns.Add(editMatpel);
			hapusMatpel = new DataGridViewButtonColumn();
			hapusMatpel.Width = 60;
			hapusMatpel.UseColumnTextForButtonValue = true;
			hapusMatpel.Text = "Hapus";
			tampilKatMatpel.Columns.Add(hapusMatpel);
		}
		
		void SimpanKatClick(object sender, EventArgs e)
		{
			string nama = nmKatBaru.Text.ToString();
			insertKatMatpel simpan = new insertKatMatpel();
			tabel = simpan.tambahKategori(nama);
			MessageBox.Show("Kategori berhasil ditambah...!!!");
			nmKatBaru.Text="";
		}
		
		void SimpanMatpelClick(object sender, EventArgs e)
		{
			string nama = nmMatPelBaru.Text.ToString();
			int durasi = Convert.ToInt32(waktuBaru.Text.ToString());
			insertKatMatpel simpan = new insertKatMatpel();
			tabel = simpan.tambahMatPel(nama,durasi);
			MessageBox.Show("Mata Pelajaran berhasil ditambah...!!!");
			nmKatBaru.Text="";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			bacaDataSiswa baca = new bacaDataSiswa();
			tabel = baca.lihatSemuaSiswa();
			tampilSiswa.DataSource = null;
			tampilSiswa.Columns.Clear();
			tampilSiswa.DataSource = tabel;
			tampilSiswa.AllowUserToAddRows = false;
			tampilSiswa.ReadOnly = true;
			tampilSiswa.Columns[0].HeaderText = "No Induk";
			tampilSiswa.Columns[0].Width = 125;
			tampilSiswa.Columns[1].HeaderText = "Nama Siswa";
			tampilSiswa.Columns[1].Width = 200;
			tampilSiswa.Columns[2].HeaderText = "Alamat";
			tampilSiswa.Columns[2].Width = 120;
			editSiswa = new DataGridViewButtonColumn();
			editSiswa.Width = 60;
			editSiswa.UseColumnTextForButtonValue = true;
			editSiswa.Text = "Edit";
			tampilSiswa.Columns.Add(editSiswa);
			hapusSiswa = new DataGridViewButtonColumn();
			hapusSiswa.Width = 60;
			hapusSiswa.UseColumnTextForButtonValue = true;
			hapusSiswa.Text = "Hapus";
			tampilSiswa.Columns.Add(hapusSiswa);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if (nInduk.Text=="" || nSiswa.Text=="" || lahirSiswa.Text=="" || almtSiswa.Text=="" || passSiswa.Text=="") 
			{
				MessageBox.Show("Data belum lengkap...!!!");
			}
			else
			{
				simpanDataSiswa simpan = new simpanDataSiswa();
				tabel = simpan.simpanDataSiswaBaru(Convert.ToInt32(nInduk.Text.ToString()),nSiswa.Text.ToString(),lahirSiswa.Text.ToString(),almtSiswa.Text.ToString(),passSiswa.Text.ToString());
				MessageBox.Show("Data berhasil disimpan...!!!");
				nInduk.Text="";
				nSiswa.Text="";
				lahirSiswa.Text="";
				almtSiswa.Text="";
				passSiswa.Text="";
			}
		}
		
		void NIndukTextChanged(object sender, EventArgs e)
		{
			try {
				int cek = Convert.ToInt32(nInduk.Text.ToString());
			} catch (Exception) {
				MessageBox.Show("No Induk harus angka..!!!");
				nInduk.Text="";
			}
		}
		
		public void TampilSoalBy(DataTable tabel)
		{
			tampilSoal.DataSource = null;
			tampilSoal.Columns.Clear();
			tampilSoal.DataSource = tabel;
			tampilSoal.AllowUserToAddRows = false;
			tampilSoal.ReadOnly = true;
			tampilSoal.Columns[0].Visible = false;
			tampilSoal.Columns[1].Visible = false;
			tampilSoal.Columns[2].Visible = false;
			tampilSoal.Columns[3].HeaderText = "No Soal";
			tampilSoal.Columns[3].Width = 85;
			tampilSoal.Columns[4].HeaderText = "Mata Pelajaran";
			tampilSoal.Columns[4].Width = 190;
			tampilSoal.Columns[5].HeaderText = "Kategori Soal";
			tampilSoal.Columns[5].Width = 190;
			tampilSoal.Columns[6].Visible = false;
			editSoal = new DataGridViewButtonColumn();
			editSoal.UseColumnTextForButtonValue = true;
			editSoal.Text = "Edit Soal";
			tampilSoal.Columns.Add(editSoal);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			if (cmbKategori.Text=="") {
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else{
				string id = cmbKategori.Text.Substring(0,1);
					if (id.Length>=2) {
					id = cmbKategori.Text.Substring(0,2);
				}
				bacaKatMatpel soal = new bacaKatMatpel();
				tabel = soal.bacaSoalPerKategori(id);
				TampilSoalBy(tabel);
			}
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			if (cmbMataPelajaran.Text=="") {
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else{
				string id = cmbMataPelajaran.Text.Substring(0,1);
					if (id.Length>=2) {
					id = cmbMataPelajaran.Text.Substring(0,2);
				}
				bacaKatMatpel soal = new bacaKatMatpel();
				tabel = soal.bacaSoalPerMatPel(id);
				TampilSoalBy(tabel);
			}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			try {
				tambahSoal f1 = new tambahSoal();
				string[] idKat = cmbKategori2.Text.Split('-');
				string[] idMatPel = cmbMataPelajaran2.Text.Split('-');
				int id_kat = Convert.ToInt32(idKat[0]);
				string nama_kat = idKat[1].ToString();
				int id_matpel = Convert.ToInt32(idMatPel[0]);
				string nama_pel = idMatPel[1].ToString();
				int no_soal=Convert.ToInt32(noSoal.Text.ToString());
				f1.id_kat = id_kat;
				f1.id_matpel = id_matpel;
				f1.no_soal = no_soal;
				f1.nama_matpel = nama_pel;
				f1.nama_kat = nama_kat;
				if (noSoal.Text=="") {
					MessageBox.Show("nomor soal masih kosong");
				}
				else{
					f1.ShowDialog();
				}
			} catch (Exception) {
				MessageBox.Show("error");
			}
			
		}
		
		void NoSoalTextChanged(object sender, EventArgs e)
		{
			try {
				int no_soal;
				no_soal = Convert.ToInt32(noSoal.Text.ToString());
			} catch (Exception) {
				MessageBox.Show("input nomor soal harus angka");
				noSoal.Text="";
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
				status_export = "1";
				string[] dSiswa = nmSiswa.Text.Split('-');
				int no_induk = Convert.ToInt32(dSiswa[0].ToString());
				bacaDataNilai nilaiSiswa = new bacaDataNilai();
				tabel = nilaiSiswa.bacaNilaiPerSiswa(no_induk);
				tampilNilai.DataSource = null;
				tampilNilai.Columns.Clear();
				tampilNilai.DataSource = tabel;
				tampilNilai.AllowUserToAddRows = false;
				tampilNilai.ReadOnly = true;
				tampilNilai.Columns[0].HeaderText = "No Soal";
				tampilNilai.Columns[0].Width = 80;
				tampilNilai.Columns[1].HeaderText = "Nama Siswa";
				tampilNilai.Columns[1].Width = 100;
				tampilNilai.Columns[2].HeaderText = "Nama Mata Pelajaran";
				tampilNilai.Columns[2].Width = 150;
				tampilNilai.Columns[3].HeaderText = "Nama Kategori Ujian";
				tampilNilai.Columns[3].Width = 150;
				tampilNilai.Columns[4].HeaderText = "Nilai Hasil";
				tampilNilai.Columns[4].Width = 85;
				
			} catch (Exception) {
				MessageBox.Show("Error");
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			try {
				status_export = "2";
				string[] dSiswa = cmbKategori3.Text.Split('-');
				int id = Convert.ToInt32(dSiswa[0].ToString());
				bacaDataNilai nilaiSiswa = new bacaDataNilai();
				tabel = nilaiSiswa.bacaNilaiPerKat(id);
				tampilNilai.DataSource = null;
				tampilNilai.Columns.Clear();
				tampilNilai.DataSource = tabel;
				tampilNilai.AllowUserToAddRows = false;
				tampilNilai.ReadOnly = true;
				tampilNilai.Columns[0].HeaderText = "No Soal";
				tampilNilai.Columns[0].Width = 80;
				tampilNilai.Columns[1].HeaderText = "Nama Siswa";
				tampilNilai.Columns[1].Width = 100;
				tampilNilai.Columns[2].HeaderText = "Nama Mata Pelajaran";
				tampilNilai.Columns[2].Width = 150;
				tampilNilai.Columns[3].HeaderText = "Nama Kategori Ujian";
				tampilNilai.Columns[3].Width = 150;
				tampilNilai.Columns[4].HeaderText = "Nilai Hasil";
				tampilNilai.Columns[4].Width = 85;
			} catch (Exception) {
				MessageBox.Show("Error");
			}
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			try {
				status_export = "3";
				string[] dSiswa = cmbMataPelajaran3.Text.Split('-');
				int id = Convert.ToInt32(dSiswa[0].ToString());
				bacaDataNilai nilaiSiswa = new bacaDataNilai();
				tabel = nilaiSiswa.bacaNilaiPerMat(id);
				tampilNilai.DataSource = null;
				tampilNilai.Columns.Clear();
				tampilNilai.DataSource = tabel;
				tampilNilai.AllowUserToAddRows = false;
				tampilNilai.ReadOnly = true;
				tampilNilai.Columns[0].HeaderText = "No Soal";
				tampilNilai.Columns[0].Width = 80;
				tampilNilai.Columns[1].HeaderText = "Nama Siswa";
				tampilNilai.Columns[1].Width = 100;
				tampilNilai.Columns[2].HeaderText = "Nama Mata Pelajaran";
				tampilNilai.Columns[2].Width = 150;
				tampilNilai.Columns[3].HeaderText = "Nama Kategori Ujian";
				tampilNilai.Columns[3].Width = 150;
				tampilNilai.Columns[4].HeaderText = "Nilai Hasil";
				tampilNilai.Columns[4].Width = 85;
			} catch (Exception) {
				MessageBox.Show("Error");
			}
		}
		
		void TampilKatMatpelCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (tampilKatMatpel.Columns[e.ColumnIndex] == editKategori && currentRow >= 0) 
			{
				string nama = tampilKatMatpel[1,currentRow].Value.ToString();
				int id = Convert.ToInt32(tampilKatMatpel[0,currentRow].Value.ToString());
				editKatMatPel f2 = new editKatMatPel();
				f2.namaLabel = nama;
				f2.idLabel = id;
				tampilKatMatpel.Update();
				f2.ShowDialog();
			}
			else if (tampilKatMatpel.Columns[e.ColumnIndex] == hapusKategori && currentRow >= 0) 
			{
				int id = Convert.ToInt32(tampilKatMatpel[0,currentRow].Value.ToString());
				hapusKatMatPel hps = new hapusKatMatPel();
				tabel = hps.hapusKat(id);
				tampilKatMatpel.Update();
				MessageBox.Show("Data Kategori berhasil dihapus");
			}
			else if (tampilKatMatpel.Columns[e.ColumnIndex] == editMatpel && currentRow >= 0) 
			{
				string nama = tampilKatMatpel[1,currentRow].Value.ToString();
				int id = Convert.ToInt32(tampilKatMatpel[0,currentRow].Value.ToString());
				editKatMatPel f2 = new editKatMatPel();
				f2.namaLabel = nama;
				f2.idLabel = id;
				f2.sts = "pel";
				f2.durasiWaktu = Convert.ToInt32(tampilKatMatpel[2,currentRow].Value.ToString());
				tampilKatMatpel.Update();
				f2.ShowDialog();
			}
			else if (tampilKatMatpel.Columns[e.ColumnIndex] == hapusMatpel && currentRow >= 0) 
			{
				int id = Convert.ToInt32(tampilKatMatpel[0,currentRow].Value.ToString());
				hapusKatMatPel hps = new hapusKatMatPel();
				tabel = hps.hapusMat(id);
				tampilKatMatpel.Update();
				MessageBox.Show("Data Mata Pelajaran berhasil dihapus...");
			}
		}
		
		void TampilSiswaCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (tampilSiswa.Columns[e.ColumnIndex] == editSiswa && currentRow >= 0) 
			{
				int id = Convert.ToInt32(tampilSiswa[0,currentRow].Value.ToString());
				editSiswa f2 = new editSiswa();
				bacaDataSiswa baca = new bacaDataSiswa();
				tabel = baca.pilihSiswa(id);
				string nama="",alamat="",kelahiran="",password="";
				foreach(DataRow kolom in tabel.Rows)
				{
					nama = kolom["nama_siswa"].ToString();
					alamat = kolom["alamat"].ToString();
					kelahiran = kolom["kelahiran"].ToString();
					password = kolom["password"].ToString();
				}
				f2.nama = nama;
				f2.alamat = alamat;
				f2.kelahiran = kelahiran;
				f2.pwd = password;
				f2.no_induk = id;
				tampilSiswa.Update();
				f2.ShowDialog();
			}
			else if (tampilSiswa.Columns[e.ColumnIndex] == hapusSiswa && currentRow >= 0) 
			{
				int id = Convert.ToInt32(tampilSiswa[0,currentRow].Value.ToString());
				hapusSiswa hps = new hapusSiswa();
				tabel = hps.hapusDataSiswa(id);
				tampilSiswa.Update();
				MessageBox.Show("Data Siswa berhasil dihapus");
			}
		}
		
		void TampilSoalCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (tampilSoal.Columns[e.ColumnIndex] == editSoal && currentRow >= 0) 
			{
				int id_soal = Convert.ToInt32(tampilSoal[0,currentRow].Value.ToString());
				int id_pel = Convert.ToInt32(tampilSoal[1,currentRow].Value.ToString());
				int id_kat = Convert.ToInt32(tampilSoal[2,currentRow].Value.ToString());
				int no_soal = Convert.ToInt32(tampilSoal[3,currentRow].Value.ToString());
				string nama_kat = tampilSoal[5,currentRow].Value.ToString();
				string nama_pel = tampilSoal[4,currentRow].Value.ToString();
				lihatKumpulanSoal f3 = new lihatKumpulanSoal();
				f3.id_kat = id_kat;
				f3.id_pel = id_pel;
				f3.id_soal = id_soal;
				f3.no_soal = no_soal;
				f3.nama_kat = nama_kat;
				f3.nama_pel = nama_pel;
				f3.ShowDialog();
			}
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			bacaDataContact baca = new bacaDataContact();
			tabel = baca.lihatSemuaContact();
			tampilContact.DataSource = null;
			tampilContact.Columns.Clear();
			tampilContact.DataSource = tabel;
			tampilContact.AllowUserToAddRows = false;
			tampilContact.ReadOnly = true;
			tampilContact.Columns[0].Visible = false;
			tampilContact.Columns[1].HeaderText = "Nama Siswa";
			tampilContact.Columns[1].Width = 180;
			tampilContact.Columns[2].HeaderText = "Pesan";
			tampilContact.Columns[2].Width = 330;
			tampilContact.Columns[3].Visible = false;
			bacaPesan = new DataGridViewButtonColumn();
			bacaPesan.Width=50;
			bacaPesan.UseColumnTextForButtonValue = true;
			bacaPesan.Text = "Baca";
			tampilContact.Columns.Add(bacaPesan);
		}
		
		void TampilContactCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (tampilContact.Columns[e.ColumnIndex] == bacaPesan && currentRow >= 0) 
			{
				int id = Convert.ToInt32(tampilContact[0,currentRow].Value.ToString());
				int id_pengirim = Convert.ToInt32(tampilContact[3,currentRow].Value.ToString());
				string nama_pengirim = tampilContact[1,currentRow].Value.ToString();
				string pesan = tampilContact[2,currentRow].Value.ToString();
				bacaDetailPesan f4 = new bacaDetailPesan();
				f4.id_pesan = id;
				f4.id_pengirim = id_pengirim;
				f4.n_siswa = nama_pengirim;
				f4.psn = pesan;
				f4.ShowDialog();
			}
		}
		
		public void ConvertData(string jdl)
		{
			XmlWriterSettings setting = new XmlWriterSettings();
			setting.Indent = true;
				
			XmlWriter writter =  XmlWriter.Create("D://"+jdl+".html",setting);
			writter.WriteStartDocument();
			writter.WriteStartElement("table");
			for (int i=0;i<tampilNilai.Rows.Count ;i++ ) {
				writter.WriteStartElement("tr");
				for (int j=0;j<tampilNilai.Columns.Count ;j++ ) {
					//(tampilNilai[0,j].Value.ToString(),tampilNilai[i,j].Value.ToString());
					writter.WriteElementString("td",tampilNilai[j,i].Value.ToString());
				}
				writter.WriteEndElement();
			}
			writter.WriteEndElement();
			writter.WriteEndDocument();
			writter.Flush();
			writter.Close();
			MessageBox.Show("Data berhasil di export");
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			try {
				string jdl_file ="";
				if (status_export=="1") {
					string[] dSiswa = nmSiswa.Text.Split('-');
					int no_induk = Convert.ToInt32(dSiswa[0].ToString());
					string nama = dSiswa[1].ToString();
					jdl_file = no_induk+"-"+nama;
					ConvertData(jdl_file);
				}
				else if (status_export=="2") {
					string[] dSiswa = cmbKategori3.Text.Split('-');
					string nama = dSiswa[1].ToString();
					jdl_file = nama;
					ConvertData(jdl_file);
				}
				else if (status_export=="3") {
					string[] dSiswa = cmbMataPelajaran3.Text.Split('-');
					string nama = dSiswa[1].ToString();
					jdl_file = nama;
					ConvertData(jdl_file);
				}
				else{
					MessageBox.Show("error");
				}
			} catch (Exception) {
				MessageBox.Show("error");
			}
		}
	}
}

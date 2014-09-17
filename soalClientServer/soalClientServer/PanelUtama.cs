/*
 * Created by SharpDevelop.
 * User: LUMBUNG
 * Date: 27/01/2011
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace soalClientServer
{
	/// <summary>
	/// Description of PanelUtama.
	/// </summary>
	public partial class PanelUtama : Form
	{
		public DataGridViewButtonColumn ikutiTes,bcPesanMasuk;
		public DataGridViewTextBoxColumn tai;
		public string no,nama,alamat,lahir,foto_usr;
		public string id_kombo="";
		public Bitmap gambar;
		DataTable tabel,siswa;
		
		public PanelUtama()
		{
			InitializeComponent();
		}
		
		void PanelUtamaLoad(object sender, EventArgs e)
		{
			tglSekarang.Text = DateTime.Now.ToString();
			noInduk.Text = no;
			namaSiswa.Text = nama;
			alamatSiswa.Text = alamat;
			kelahiran.Text = lahir;
			noIndukEdit.Text = no;
			namaEdit.Text = nama;
			kelahiranEdit.Text = lahir;
			alamatEdit.Text = alamat;
			KategoriSoal();
			MataPelajaran();
			nmPengirim.Text=nama;
			btnKirimPesan.Enabled=false;
			try {
				gbr_foto.ImageLocation = "D://foto_user/"+foto_usr+"";
				gbr_foto2.ImageLocation = "D://foto_user/"+foto_usr+"";
			} catch {
				gbr_foto.Image = gbr_foto.ErrorImage;
				gbr_foto2.Image = gbr_foto.ErrorImage;
			}
		}
		
		public void KategoriSoal()
		{
			bacaData kategori = new bacaData();
			tabel = kategori.bacaKategoriSoal();
			foreach(DataRow kolom in tabel.Rows)
			{
				string id = kolom["id_kat"].ToString();
				string nm_kat = kolom["nama_kat"].ToString();
				string gbng = ""+id+"-"+nm_kat+"";
				cmbKategori.Items.Add(gbng);
				cmbKategori2.Items.Add(gbng);
			}
		}
		
		public void MataPelajaran()
		{
			bacaData pelajaran = new bacaData();
			tabel = pelajaran.bacaKategoriMataPelajaran();
			foreach(DataRow kolom in tabel.Rows)
			{
				string id = kolom["id_pel"].ToString();
				string nm_kat = kolom["nama_pel"].ToString();
				string gbng = ""+id+"-"+nm_kat+"";
				cmbMataPelajaran.Items.Add(gbng);
				cmbMataPelajaran2.Items.Add(gbng);
			}
		}
		
		void PanelUtamaFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (cmbKategori.Text=="") {
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else{
				string id = cmbKategori.Text.Substring(0,1);
					if (id.Length>=2) {
					id = cmbKategori.Text.Substring(0,2);
				}
				bacaData soal = new bacaData();
				tabel = soal.bacaSoalPerKategori(id);
				TampilSoalBy(tabel);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (cmbMataPelajaran.Text=="") {
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else{
				string id = cmbMataPelajaran.Text.Substring(0,1);
					if (id.Length>=2) {
					id = cmbMataPelajaran.Text.Substring(0,2);
				}
				bacaData soal = new bacaData();
				tabel = soal.bacaSoalPerMatPel(id);
				TampilSoalBy(tabel);
			}
		}
		
		public void TampilSoalBy(DataTable tabeldata)
		{
			tampilSoal.DataSource = null;
			tampilSoal.Columns.Clear();
			tampilSoal.DataSource = tabeldata;
			tampilSoal.AllowUserToAddRows = false;
			tampilSoal.ReadOnly = true;
			tampilSoal.Columns[0].Visible = false;
			tampilSoal.Columns[1].Visible = false;
			tampilSoal.Columns[2].Visible = false;
			tampilSoal.Columns[3].HeaderText = "No Soal";
			tampilSoal.Columns[3].Width = 110;
			tampilSoal.Columns[4].HeaderText = "Mata Pelajaran";
			tampilSoal.Columns[4].Width = 220;
			tampilSoal.Columns[5].HeaderText = "Kategori Soal";
			tampilSoal.Columns[5].Width = 220;
			tampilSoal.Columns[6].Visible = false;
			ikutiTes = new DataGridViewButtonColumn();
			ikutiTes.HeaderText = "Ikuti Tes Soal";
			ikutiTes.UseColumnTextForButtonValue = true;
			ikutiTes.Text = "Ikut Tes";
			tampilSoal.Columns.Add(ikutiTes);
		}
		
		public void TampilSemuaSoal()
		{
			bacaData soal = new bacaData();
			tabel = soal.bacaSemuaSoal();
			tampilSoal.DataSource = null;
			tampilSoal.Columns.Clear();
			tampilSoal.DataSource = tabel;
			tampilSoal.AllowUserToAddRows = false;
			tampilSoal.ReadOnly = true;
			tampilSoal.Columns[0].Visible = false;
			tampilSoal.Columns[1].Visible = false;
			tampilSoal.Columns[2].Visible = false;
			tampilSoal.Columns[3].HeaderText = "No Soal";
			tampilSoal.Columns[3].Width = 110;
			tampilSoal.Columns[4].HeaderText = "Mata Pelajaran";
			tampilSoal.Columns[4].Width = 220;
			tampilSoal.Columns[5].HeaderText = "Kategori Soal";
			tampilSoal.Columns[5].Width = 220;
			tampilSoal.Columns[6].Visible = false;
			ikutiTes = new DataGridViewButtonColumn();
			ikutiTes.HeaderText = "Ikuti Tes Soal";
			ikutiTes.UseColumnTextForButtonValue = true;
			ikutiTes.Text = "Ikut Tes";
			tampilSoal.Columns.Add(ikutiTes);
		}
		
		void TampilSoalCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int baris = int.Parse(e.RowIndex.ToString());
			int no_soal = int.Parse(tampilSoal[3,baris].Value.ToString());
			string id_pel = tampilSoal[1,baris].Value.ToString();
			string id_kat = tampilSoal[2,baris].Value.ToString();
			string matpel = tampilSoal[4,baris].Value.ToString();
			string kat = tampilSoal[5,baris].Value.ToString();
			string lama = tampilSoal[6,baris].Value.ToString();
			if (tampilSoal.Columns[e.ColumnIndex] == ikutiTes && baris >=0) {
				TesSoal f2 = new TesSoal();
				f2.no = no;
				f2.nama = nama;
				f2.lahir = lahir;
				f2.alamat = alamat;
				f2.matpel = matpel;
				f2.kat = kat;
				f2.id_matpel = id_pel;
				f2.id_kat = id_kat;
				f2.no_soal = no_soal.ToString();
				f2.lama = Convert.ToInt32(lama);
				f2.Show();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			TampilSemuaSoal();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			bacaNilai nilaiPerKat = new bacaNilai();
			tabel = nilaiPerKat.bacaSemuaNilai(Convert.ToInt32(no));
			Tampilan(tabel);
			
			totSoal.Text = JumlahSemuaSoal().ToString();
			
			int bnykData;
			int total=0;
			bnykData = tampilNilai.Rows.Count;
			for (int i=0;i<bnykData ;i++ ) {
				total = Convert.ToInt32(total + Convert.ToInt32(tampilNilai[3,i].Value));
			}
			rataRata.Text = (Convert.ToSingle(total/JumlahSemuaSoal())).ToString();
		}
		
		public int JumlahSemuaSoal()
		{
			int banyak;
			bacaSoal jumlah = new bacaSoal();
			tabel = jumlah.BacaSemuaSoal();
			banyak = tabel.Rows.Count;
			return banyak;
		}
		
		public void Tampilan(DataTable tabeldata)
		{
			tampilNilai.DataSource = null;
			tampilNilai.Columns.Clear();
			tampilNilai.DataSource = tabeldata;
			tampilNilai.AllowUserToAddRows = false;
			tampilNilai.ReadOnly = true;
			tampilNilai.Columns[0].HeaderText = "No Soal";
			tampilNilai.Columns[0].Width = 100;
			tampilNilai.Columns[1].HeaderText = "Nama Mata Pelajaran";
			tampilNilai.Columns[1].Width = 200;
			tampilNilai.Columns[2].HeaderText = "Nama Kategori Ujian";
			tampilNilai.Columns[2].Width = 230;
			tampilNilai.Columns[3].HeaderText = "Nilai Hasil";
			tampilNilai.Columns[3].Width = 140;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if (cmbKategori2.Text=="") 
			{
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else
			{
				id_kombo = cmbKategori2.Text.Substring(0,1);
				if (id_kombo.Length>=2) 
				{
					id_kombo = cmbKategori2.Text.Substring(0,2);
				}
				bacaNilai nilaiPerKat = new bacaNilai();
				tabel = nilaiPerKat.bacaNilaiPerKat(Convert.ToInt32(no),Convert.ToInt32(id_kombo));
				Tampilan(tabel);
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			bacaRanking ranking = new bacaRanking();
			tabel = ranking.bacaSemuaRanking();
			
			bacaSiswa jmlsiswa = new bacaSiswa();
			siswa = jmlsiswa.bacaTotalSiswa();
			
			totalSiswa.Text = Convert.ToString(Convert.ToInt32(siswa.Rows.Count));
			siswaIkut.Text = Convert.ToString(Convert.ToInt32(tabel.Rows.Count));
			tampilRanking.ReadOnly = true;
			tampilRanking.AllowUserToAddRows = false;
			tampilRanking.DataSource = null;
			tampilRanking.Columns.Clear();
			tampilRanking.DataSource = tabel;
			tampilRanking.Columns[0].HeaderText = "Nomor Induk Siswa";
			tampilRanking.Columns[0].Width = 170;
			tampilRanking.Columns[1].HeaderText = "Nama Siswa";
			tampilRanking.Columns[1].Width = 300;
			tampilRanking.Columns[2].HeaderText = "Rata-Rata Nilai";
			tampilRanking.Columns[2].Width = 200;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (cmbMataPelajaran2.Text=="")
			{
				MessageBox.Show("Uppzz, error cuy...!!!");
			}
			else
			{
				id_kombo = cmbMataPelajaran2.Text.Substring(0,1);
				if (id_kombo.Length>=2) 
				{
					id_kombo = cmbMataPelajaran2.Text.Substring(0,2);
				}
			bacaNilai nilaiPerKat = new bacaNilai();
			tabel = nilaiPerKat.bacaNilaiPerMatPel(Convert.ToInt32(no),Convert.ToInt32(id_kombo));
			Tampilan(tabel);
			}
		}
		
		void PwdLamaEditTextChanged(object sender, EventArgs e)
		{
			Login cek = new Login();
			tabel = cek.ValidasiLogin(no,pwdLamaEdit.Text.ToString());
			if(tabel.Rows.Count>0)
			{
				statusPwdLama.Text = "BENAR";
			}
			else{
				statusPwdLama.Text ="SALAH";
			}
			
			if (statusUlangPwdBaru.Text=="BENAR" && statusPwdLama.Text=="BENAR" && pwdBaruUlangEdit.Text!="" && pwdBaruEdit.Text!="") 
			{
				btnGantiPwd.Enabled = true;
			}
			else
			{
				btnGantiPwd.Enabled = false;
				statusUlangPwdBaru.Text = "SALAH";
			}
		}
		
		void PwdBaruEditTextChanged(object sender, EventArgs e)
		{
			if (pwdBaruEdit.Text.Length>5) 
			{
				statusPwdBaru.Text = "KUAT";
			}
			else
			{
				statusPwdBaru.Text = "LEMAH";
			}
			
			if (pwdBaruUlangEdit.Text.ToString()==pwdBaruEdit.Text.ToString()) 
			{
				statusUlangPwdBaru.Text = "BENAR";
			}
			else
			{
				statusUlangPwdBaru.Text = "SALAH";
			}
			
			if (statusUlangPwdBaru.Text=="BENAR" && statusPwdLama.Text=="BENAR" && pwdBaruUlangEdit.Text!="" && pwdBaruEdit.Text!="") 
			{
				btnGantiPwd.Enabled = true;
			}
			else
			{
				btnGantiPwd.Enabled = false;
				statusUlangPwdBaru.Text = "SALAH";
			}
		}
		
		void PwdBaruUlangEditTextChanged(object sender, EventArgs e)
		{
			if (pwdBaruUlangEdit.Text.ToString()==pwdBaruEdit.Text.ToString()) 
			{
				statusUlangPwdBaru.Text = "BENAR";
			}
			else
			{
				statusUlangPwdBaru.Text = "SALAH";
			}
			
			if (statusUlangPwdBaru.Text=="BENAR" && statusPwdLama.Text=="BENAR" && pwdBaruUlangEdit.Text!="" && pwdBaruEdit.Text!="") 
			{
				btnGantiPwd.Enabled = true;
			}
			else
			{
				btnGantiPwd.Enabled = false;
				statusUlangPwdBaru.Text = "SALAH";
			}
		}
		
		void BtnGantiPwdClick(object sender, EventArgs e)
		{
			bacaSiswa updatePwd = new bacaSiswa();
			tabel = updatePwd.UpdatePasswordSiswa(Convert.ToInt32(no),pwdBaruUlangEdit.Text.ToString());
			MessageBox.Show("Password / Kata Sandi untuk Log In berhasil di-update...!!!");
			pwdBaruEdit.Text="";
			pwdBaruUlangEdit.Text="";
			pwdLamaEdit.Text="";
			statusUlangPwdBaru.Text="";
			statusPwdLama.Text="";
			statusPwdBaru.Text="";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			bacaSiswa updateData = new bacaSiswa();
			tabel = updateData.UpdateDataSiswa(Convert.ToInt32(no),namaEdit.Text.ToString(),kelahiranEdit.Text.ToString(),alamatEdit.Text.ToString());
			MessageBox.Show("Data berhasil di-update...!!!");
			namaSiswa.Text = namaEdit.Text.ToString();
			kelahiran.Text = kelahiranEdit.Text.ToString();
			alamatSiswa.Text = alamatEdit.Text.ToString();
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			bacaContact bc = new bacaContact();
			tabel = bc.bacaPesanMasuk(Convert.ToInt32(no));
			if (tabel.Rows.Count<1) {
				MessageBox.Show("Belum ada pesan masuk untuk anda");
			}
			pesanMasuk.DataSource = null;
			pesanMasuk.Columns.Clear();
			pesanMasuk.DataSource = tabel;
			pesanMasuk.AllowUserToAddRows = false;
			pesanMasuk.ReadOnly = true;
			pesanMasuk.Columns[0].Visible = false;
			pesanMasuk.Columns[1].HeaderText = "Pengirim";
			pesanMasuk.Columns[1].Width = 70;
			pesanMasuk.Columns[2].Visible = false;
			pesanMasuk.Columns[3].HeaderText = "Pesan";
			pesanMasuk.Columns[3].Width = 220;
			bcPesanMasuk = new DataGridViewButtonColumn();
			bcPesanMasuk.UseColumnTextForButtonValue = true;
			bcPesanMasuk.Width=80;
			bcPesanMasuk.Text = "Baca";
			pesanMasuk.Columns.Add(bcPesanMasuk);
		}
		
		void PesanPengirimTextChanged(object sender, EventArgs e)
		{
			if (pesanPengirim.Text=="") {
				btnKirimPesan.Enabled=false;
			}
			else{
				btnKirimPesan.Enabled=true;
			}
		}
		
		void BtnKirimPesanClick(object sender, EventArgs e)
		{
			simpanPesan smpn = new simpanPesan();
			tabel = smpn.kirimPesan(no,pesanPengirim.Text.ToString());
			MessageBox.Show("Pesan Terkirim");
			pesanPengirim.Text="";
		}
		
		void PesanMasukCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
			if (pesanMasuk.Columns[e.ColumnIndex] == bcPesanMasuk && currentRow >= 0) 
			{
				int id_psn = Convert.ToInt32(pesanMasuk[0,currentRow].Value.ToString());
				string pengirim = pesanMasuk[1,currentRow].Value.ToString();
				string penerima = pesanMasuk[2,currentRow].Value.ToString();
				string pesan = pesanMasuk[3,currentRow].Value.ToString();
				bacaDetailPesan f5 = new bacaDetailPesan();
				f5.n_siswa = penerima;
				f5.psn = pesan;
				f5.id_pesan = id_psn;
				f5.id_pengirim = pengirim;
				f5.ShowDialog();
			}
		}
		
		void BtnGantiFotoClick(object sender, EventArgs e)
		{
			int panjang_gambar=0, tinggi_gambar=0, ukuran_bagi;
			try {
				openFoto.ShowDialog();
				foto = openFoto.FileName;
				gambar = new Bitmap(Image.FromFile(foto));
				panjang_gambar = gambar.Width;
				tinggi_gambar = gambar.Height;
				if (panjang_gambar>tinggi_gambar) {
					ukuran_bagi = panjang_gambar/65;
					panjang_gambar = panjang_gambar/ukuran_bagi;
					tinggi_gambar = tinggi_gambar/ukuran_bagi;
					gambar = new Bitmap(gambar,panjang_gambar,tinggi_gambar);
					gbr_foto.Image = gambar;
					gbr_foto2.Image = gambar;
				}
				else{
					ukuran_bagi = tinggi_gambar/75;
					panjang_gambar = panjang_gambar/ukuran_bagi;
					tinggi_gambar = tinggi_gambar/ukuran_bagi;
					gambar = new Bitmap(gambar,panjang_gambar,tinggi_gambar);
					gbr_foto.Image = gambar;
					gbr_foto2.Image = gambar;
				}
				bacaSiswa updt = new bacaSiswa();
				string nama_baru = ""+no+".jpg";
				tabel = updt.UpdateFoto(Convert.ToInt32(no),nama_baru);
				string lokasi = "D://foto_user/"+nama_baru+"";
				gambar.Save(lokasi);
			} 
			catch (Exception) {
				
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Anda telah berhasil Log Out dan aplikasi tes online akan ditutup.");
			this.Close();
		}
	}
}

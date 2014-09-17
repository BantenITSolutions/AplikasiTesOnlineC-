/*
 * Created by SharpDevelop.
 * User: LUMBUNG
 * Date: 30/01/2011
 * Time: 9:36
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
	/// Description of TesSoal.
	/// </summary>
	public partial class TesSoal : Form
	{
		public string no,nama,alamat,lahir,id_matpel,id_kat,no_soal,matpel,kat;
		public string id_soal,jwb,jwbnasli,tampungIdSoal="";
		public int counter=1;
		public int seconds,minutes,hours,lama;
		DataTable tabel,simpan,hitungBenar,hitungSalah;
		public TesSoal()
		{
			InitializeComponent();
		}
		
		void TesSoalLoad(object sender, EventArgs e)
		{
			noInduk.Text = no;
			namaSiswa.Text = nama;
			alamatSiswa.Text = alamat;
			kelahiran.Text = lahir;
			matPel.Text = matpel;
			katSoal.Text = kat;
			noSoal.Text = no_soal;
			tampilNoSoal.Text = counter.ToString();
			tampilSoalBelumTerjawab.Text = "20";
			tampilSoalTerjawab.Text = "0";
			hours = Convert.ToInt32(lama/60);
			minutes = Convert.ToInt32(lama-(hours*60));
			TampilSoal();
			CekSoal();
			//Cek();
		}
		/*
		public void Cek()
		{
			int benar = 0;
					koneksi Hasil= new koneksi();
					tabel = new DataTable();
					tabel = Hasil.pilihData("select count(tbl_jawab_soal.kunci) as jml from tbl_jawab_soal where id_kat_soal="+id_kat+" and no_soal="+no_soal+" and id_siswa="+no+" and kunci='benar'");
					foreach(DataRow kolom in tabel.Rows)
					{
						benar = Convert.ToInt32(kolom["jml"].ToString());
					}
					MessageBox.Show(benar.ToString());
		}
		*/
		void TesSoalFormClosed(object sender, FormClosedEventArgs e)
		{
			//System.Windows.Forms.Application.Exit();
		}
		
		public void CekSoal()
		{
			string idPel="",idKatSoal="",noSoal="",idSiswa="";
			
			bacaSoal cek = new bacaSoal();
			tabel = cek.CekIkutSerta(id_kat,id_matpel,no_soal,no);
			foreach(DataRow kolom in tabel.Rows)
			{
				idKatSoal=kolom["id_kat_soal"].ToString();
				idPel=kolom["id_pel"].ToString();
				noSoal=kolom["no_soal"].ToString();
				idSiswa=kolom["id_siswa"].ToString();
			}
			if (idKatSoal==id_kat && idPel==id_matpel && noSoal==no_soal && idSiswa==no) {
				MessageBox.Show("Anda sudah mengikuti tes ini...!!!!");
				this.Close();
			}
		}
		
		public void TampilSoal()
		{
			bacaSoal acak = new bacaSoal();
			tabel = acak.TampilSoalAcak(no_soal,id_matpel,id_kat);
			foreach(DataRow kolom in tabel.Rows)
			{
				soalTampil.Text = kolom["pertanyaan"].ToString();
				jwbA.Text = "a. "+kolom["jwb_a"].ToString();
				jwbB.Text = "b. "+kolom["jwb_b"].ToString();
				jwbC.Text = "c. "+kolom["jwb_c"].ToString();
				jwbD.Text = "d. "+kolom["jwb_d"].ToString();
				id_soal = kolom["id_soal"].ToString();
				jwbnasli = kolom["kunci"].ToString();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			TampilSoal();
			string[] kumpulId = tampungIdSoal.Split('|');
				foreach(string id in kumpulId)
				{
					if (id==id_soal) {
						TampilSoal();
						foreach(string id2 in kumpulId)
						{
							if (id2==id_soal) {
								TampilSoal();
							}
						}
					}
				}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string inJwbn="";
			int salah=0;
			float hasil=0;
			int benar=0;
			if (jwbA.Checked==false && jwbB.Checked==false && jwbC.Checked==false && jwbD.Checked==false) {
				MessageBox.Show("Anda belum memilih jawaban...!!!");
			}
			else{
				if (jwbA.Checked==true) {				
					jwb = jwbA.Text.Substring(0,1);
				}
				else if (jwbB.Checked==true) {
					jwb = jwbB.Text.Substring(0,1);
				}
				else if (jwbC.Checked==true) {
					jwb = jwbC.Text.Substring(0,1);
				}
				else if (jwbD.Checked==true){
					jwb = jwbD.Text.Substring(0,1);
				}
				if (jwb==jwbnasli) {
					inJwbn = "benar";
				}
				else{
					inJwbn = "salah";
				}
				simpanJawaban simpanhasil = new simpanJawaban();
				tabel = simpanhasil.SimpanHasilJawaban(id_soal,id_kat,no_soal,id_matpel,no,inJwbn);
				tampungIdSoal +=""+id_soal+"|";
				counter++;
				tampilNoSoal.Text = counter.ToString();
				tampilSoalTerjawab.Text = Convert.ToString(Convert.ToInt32(counter-1));
				tampilSoalBelumTerjawab.Text = Convert.ToString(Convert.ToInt32(20-counter+1));
				if (counter>20) {
					string kondisi_salah = "salah";
					string kondisi_benar = "benar";
					hitungBenar = simpanhasil.HitungKebenaranSoal(Convert.ToInt32(id_kat),Convert.ToInt32(no_soal),Convert.ToInt32(no),kondisi_benar);
					hitungSalah = simpanhasil.HitungKebenaranSoal(Convert.ToInt32(id_kat),Convert.ToInt32(no_soal),Convert.ToInt32(no),kondisi_salah);
					benar = Convert.ToInt32(hitungBenar.Rows.Count);
					salah = Convert.ToInt32(hitungSalah.Rows.Count);
					
					hasil = Convert.ToSingle(simpanhasil.HasilNilaiAkhir(benar));
					
					simpan = simpanhasil.SimpanHasilAkhir(Convert.ToInt32(id_kat),Convert.ToInt32(id_matpel),Convert.ToInt32(no_soal),Convert.ToInt32(no),salah,benar,hasil.ToString());
					
					MessageBox.Show("Semua soal sudah terjawab...!!!\nJawaban yang benar = "+benar+"");
					this.Close();
				}
				
				string[] kumpulId = tampungIdSoal.Split('|');
				foreach(string id in kumpulId)
				{
					if (id==id_soal) {
						TampilSoal();
						foreach(string id2 in kumpulId)
						{
							if (id2==id_soal) {
								TampilSoal();
							}
						}
					}
				}
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			int salah=0;
			float hasil=0;
			int benar=0;
			if ((minutes == 0) && (hours == 0) && (seconds == 0))
            {
                timer1.Enabled = false;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
				string kondisi_salah = "salah";
				string kondisi_benar = "benar";
				simpanJawaban simpanhasil = new simpanJawaban();
				hitungBenar = simpanhasil.HitungKebenaranSoal(Convert.ToInt32(id_kat),Convert.ToInt32(no_soal),Convert.ToInt32(no),kondisi_benar);
				hitungSalah = simpanhasil.HitungKebenaranSoal(Convert.ToInt32(id_kat),Convert.ToInt32(no_soal),Convert.ToInt32(no),kondisi_salah);
				benar = Convert.ToInt32(hitungBenar.Rows.Count);
				salah = Convert.ToInt32(hitungSalah.Rows.Count);
					
				hasil = Convert.ToSingle(simpanhasil.HasilNilaiAkhir(benar));
					
				simpan = simpanhasil.SimpanHasilAkhir(Convert.ToInt32(id_kat),Convert.ToInt32(id_matpel),Convert.ToInt32(no_soal),Convert.ToInt32(no),salah,benar,hasil.ToString());
					
				MessageBox.Show("Waktu untuk mengerjakan soal sudah habis...!!!\n\nJawaban yang benar = "+benar+"");
				this.Close();
            }
            else
            {
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;
                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                seconds -= 1;
                lblHr.Text = hours.ToString();
                lblMin.Text = minutes.ToString();
                lblSec.Text = seconds.ToString();
            }
		}
	}
}

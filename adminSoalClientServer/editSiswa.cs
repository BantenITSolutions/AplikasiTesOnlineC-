/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 12/03/2011
 * Time: 9:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace adminSoalClientServer
{
	public partial class editSiswa : Form
	{
		DataTable tabel;
		public string nama,kelahiran,alamat,pwd;
		public int no_induk;
		public editSiswa()
		{
			InitializeComponent();
		}
		
		void EditSiswaLoad(object sender, EventArgs e)
		{
			nInduk.Text = no_induk.ToString();
			lahir.Text = kelahiran;
			almt.Text = alamat;
			nSiswa.Text = nama;
			passLama.Text=pwd;
		}
		
		void PassLamaTextChanged(object sender, EventArgs e)
		{
			if (passLama.Text!=pwd) {
				inPasLama.Text="X";
				btnSimpan.Enabled=false;
			}
			else if(passLama.Text==pwd){
				inPasLama.Text="OK";
			}
			else if(passLama.Text==""){
				inPasLama.Text="";
				inUlangPass.Text="";
				btnSimpan.Enabled=true;
			}
		}
		
		void PassBaruTextChanged(object sender, EventArgs e)
		{
			if (passBaru.Text.Length>=5) {
				inPasBaru.Text="STRONG";
			}
			else if(passBaru.Text.Length<5){
				inPasBaru.Text="WEAK";
			}
			else{
				btnSimpan.Enabled=false;
			}
		}
		
		void UlangPassTextChanged(object sender, EventArgs e)
		{
			if (passBaru.Text!=ulangPass.Text) {
				inUlangPass.Text="X";
				btnSimpan.Enabled=false;
			}
			else{
				inUlangPass.Text="OK";
				btnSimpan.Enabled=true;
			}
		}
		
		void UbhPassCheckedChanged(object sender, EventArgs e)
		{
			if (ubhPass.Checked!=true) {
				passLama.ReadOnly=true;
				passBaru.ReadOnly=true;
				ulangPass.ReadOnly=true;
				btnSimpan.Enabled=true;
				passLama.Text=pwd;
				passBaru.Text="";
				ulangPass.Text="";
				inUlangPass.Text="";
				inPasBaru.Text="";
				inPasLama.Text="";
			}
			else{
				passLama.ReadOnly=false;
				passBaru.ReadOnly=false;
				ulangPass.ReadOnly=false;
				btnSimpan.Enabled=false;
				passLama.Text=pwd;
				passBaru.Text="";
				ulangPass.Text="";
				inUlangPass.Text="";
				inPasBaru.Text="";
				inPasLama.Text="";
			}
		}
		
		void BtnSimpanClick(object sender, EventArgs e)
		{
			if (ubhPass.Checked==true) {
				simpanDataSiswa simpan = new simpanDataSiswa();
				tabel=simpan.simpanUpdateSiswa(no_induk,nSiswa.Text.ToString(),lahir.Text.ToString(),almt.Text.ToString(),passBaru.Text.ToString());
				MessageBox.Show("data berhasil disimpan");
				this.Close();
			}
			else{
				simpanDataSiswa simpan = new simpanDataSiswa();
				tabel=simpan.simpanUpdateSiswa(no_induk,nSiswa.Text.ToString(),lahir.Text.ToString(),almt.Text.ToString(),pwd);
				MessageBox.Show("data berhasil disimpan");
				this.Close();
			}
		}
	}
}

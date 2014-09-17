/*
 * Created by SharpDevelop.
 * User: LUMBUNG
 * Date: 29/01/2011
 * Time: 22:32
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
	/// <summary>
	/// Description of koneksi.
	/// </summary>
	public class koneksi
	{
		public MySqlConnection konek;
		MySqlCommand komand;
		DataTable tabel;
		MySqlDataAdapter adap;
		
		string konfigKoneksi = "server=localhost; database=tesonline; uid=root; pwd=";
		public void koneksiBuka()
		{
			konek = new MySqlConnection(konfigKoneksi);
			konek.Open();
		}
		public void koneksiTutup()
		{
			konek = new MySqlConnection(konfigKoneksi);
			konek.Close();
		}
		
		public DataTable pilihData(string query)
		{
			try {
				konek.Open();
				komand = new MySqlCommand(query,konek);
				konek.Close();
				tabel = new DataTable();
				adap = new MySqlDataAdapter(komand);
				adap.Fill(tabel);
			} catch (Exception err) {
				MessageBox.Show(err.ToString());
			}
				return tabel;
		}
		
		public DataTable hasilTes(int id_kat,int no_soal, int no_induk)
		{
			DataTable hasil = new DataTable();
			string q = String.Format("call tampilHasilTesSementara({0},{1},{2})",Convert.ToInt32(id_kat),Convert.ToInt32(no_soal),Convert.ToInt32(no_induk));
			try {
				konek.Open();
				komand = new MySqlCommand(q,konek);
				konek.Close();
				adap = new MySqlDataAdapter(komand);
				adap.Fill(hasil);
			} catch (Exception) {
				
			}
				return hasil;
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 11:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace adminSoalClientServer
{
	public class simpanDataSoal
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql;
		
		public DataTable simpanSoal(int no_soal, int id_pel, int id_kat, string soal, string jwbA, string jwbB, string jwbC, string jwbD, string kunci)
		{
			classKoneksi = new koneksi();
			sql = "call simpanSoal("+no_soal+","+id_pel+","+id_kat+",'"+soal+"','"+jwbA+"','"+jwbB+"','"+jwbC+"','"+jwbD+"','"+kunci+"')";
			tabel = new DataTable();
			
			try {
				classKoneksi.koneksiBuka();
				komand = new MySqlCommand(sql,classKoneksi.konek);
				adapter = new MySqlDataAdapter(komand);
				adapter.Fill(tabel);
			} catch (Exception) {
				
			}
			classKoneksi.koneksiTutup();
			return tabel;
		}
		
		public DataTable updateSoal(int id_soal, string soal, string jwbA, string jwbB, string jwbC, string jwbD, string kunci)
		{
			classKoneksi = new koneksi();
			sql = "call updateSoal("+id_soal+",'"+soal+"','"+jwbA+"','"+jwbB+"','"+jwbC+"','"+jwbD+"','"+kunci+"')";
			tabel = new DataTable();
			
			try {
				classKoneksi.koneksiBuka();
				komand = new MySqlCommand(sql,classKoneksi.konek);
				adapter = new MySqlDataAdapter(komand);
				adapter.Fill(tabel);
			} catch (Exception) {
				
			}
			classKoneksi.koneksiTutup();
			return tabel;
		}
	}
}

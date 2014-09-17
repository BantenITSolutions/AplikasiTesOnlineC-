/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 10/03/2011
 * Time: 21:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace adminSoalClientServer
{
	public class insertKatMatpel
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql;
	
		public DataTable tambahKategori(string nama)
		{
			classKoneksi = new koneksi();
			sql = "call simpanKategori('"+nama+"')";
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
	
		public DataTable tambahMatPel(string nama_pel, int durasi)
		{
			classKoneksi = new koneksi();
			sql = "call simpanMatPel('"+nama_pel+"',"+durasi+")";
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
	
		public DataTable updateKat(string nama_pel,int id)
		{
			classKoneksi = new koneksi();
			sql = "call updateKat('"+nama_pel+"',"+id+")";
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
	
		public DataTable updateMat(string nama_pel,int durasi,int id)
		{
			classKoneksi = new koneksi();
			sql = "call updateMat('"+nama_pel+"',"+durasi+","+id+")";
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

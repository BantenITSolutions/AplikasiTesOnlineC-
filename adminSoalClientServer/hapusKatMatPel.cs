/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 11/03/2011
 * Time: 23:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace adminSoalClientServer
{
	/// <summary>
	/// Description of hapusKatMatPel.
	/// </summary>
	public class hapusKatMatPel
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql;
		
		public DataTable hapusKat(int id)
		{
			classKoneksi = new koneksi();
			sql = "call hapusKat("+id+")";
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
		
		public DataTable hapusMat(int id)
		{
			classKoneksi = new koneksi();
			sql = "call hapusMat("+id+")";
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

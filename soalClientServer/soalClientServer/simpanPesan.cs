/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 13/03/2011
 * Time: 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of simpanPesan.
	/// </summary>
	public class simpanPesan
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql;
		
		public DataTable kirimPesan(string pengirim,string psn)
		{
			classKoneksi = new koneksi();
			sql = "call kirimPesanClient('"+pengirim+"','"+psn+"')";
			tabel = new DataTable();
			
			try 
			{
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

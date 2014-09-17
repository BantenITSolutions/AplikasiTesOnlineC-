/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/02/2011
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of bacaRanking.
	/// </summary>
	public class bacaRanking
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		string sql;
		DataTable tabel;
		koneksi classKoneksi;
		
		public DataTable bacaSemuaRanking()
		{
			classKoneksi = new koneksi();
			sql = "call lihatRanking";
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

/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 19/02/2011
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public class Login
	{
		MySqlCommand komand;
		MySqlDataAdapter adapter;
		koneksi classKoneksi;
		string sql;
		DataTable tabel;
		
		public DataTable ValidasiLogin(string user, string pass)
		{
			classKoneksi = new koneksi();
			sql = "call loginUser('"+user+"','"+pass+"')";
			tabel = new DataTable();
			
			try 
			{
				classKoneksi.koneksiBuka();
				komand = new MySqlCommand(sql,classKoneksi.konek);
				adapter = new MySqlDataAdapter(komand);
				adapter.Fill(tabel);
			} catch (Exception) 
			{
				
			}
			classKoneksi.koneksiTutup();
			return tabel;
			
		}
	}
}

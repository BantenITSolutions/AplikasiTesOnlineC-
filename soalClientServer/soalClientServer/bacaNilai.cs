/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/02/2011
 * Time: 5:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of bacaNilai.
	/// </summary>
	public class bacaNilai
	{
		MySqlCommand komand;
		MySqlDataAdapter adapter;
		koneksi classKoneksi;
		string sql;
		DataTable tabel;
		
		public DataTable bacaNilaiPerKat(int no_induk,int id_kat)
		{
			classKoneksi = new koneksi();
			sql = "call lihatNilaiPerKat("+no_induk+","+id_kat+")";
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
		
		public DataTable bacaNilaiPerMatPel(int no_induk, int id_matpel)
		{
			classKoneksi = new koneksi();
			sql = "call lihatNilaiPerMatPel("+no_induk+","+id_matpel+")";
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
		
		public DataTable bacaSemuaNilai(int no_induk)
		{
			classKoneksi = new koneksi();
			sql = "call lihatSemuaNilai("+no_induk+")";
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

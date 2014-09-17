/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/02/2011
 * Time: 0:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of bacaSoal.
	/// </summary>
	public class bacaSoal
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql;
		
		public DataTable CekIkutSerta(string id_kat,string id_pel,string no_soal,string id_siswa)
		{
			classKoneksi = new koneksi();
			sql = "call cekIkutSerta('"+id_kat+"','"+id_pel+"','"+no_soal+"','"+id_siswa+"')";
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
		
		public DataTable TampilSoalAcak(string no_soal,string id_matpel,string id_kat)
		{
			classKoneksi = new koneksi();
			sql = "call AcakSoal("+no_soal+","+id_matpel+","+id_kat+")";
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
		
		public DataTable BacaSemuaSoal()
		{
			classKoneksi = new koneksi();
			sql = "call lihatSemuaSoal";
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

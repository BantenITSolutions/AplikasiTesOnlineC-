/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/02/2011
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of bacaSiswa.
	/// </summary>
	public class bacaSiswa
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		DataTable tabel;
		string sql;
		koneksi classKoneksi;
		
		public DataTable bacaTotalSiswa()
		{
			classKoneksi = new koneksi();
			sql = "call totalSiswa";
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
		
		public DataTable UpdatePasswordSiswa(int no_induk,string pwd)
		{
			classKoneksi = new koneksi();
			sql = "call updatePasswordSiswa("+no_induk+",'"+pwd+"')";
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
		
		public DataTable UpdateDataSiswa(int no_induk,string nama,string lahir,string alamat)
		{
			classKoneksi = new koneksi();
			sql = "call updateDataSiswa("+no_induk+",'"+nama+"','"+lahir+"','"+alamat+"')";
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
		
		public DataTable UpdateFoto(int no_induk, string nama_baru)
		{
			classKoneksi = new koneksi();
			sql = "call updateFotoSiswa("+no_induk+",'"+nama_baru+"')";
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

/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/02/2011
 * Time: 0:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace soalClientServer
{
	/// <summary>
	/// Description of simpanJawaban.
	/// </summary>
	public class simpanJawaban
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		DataTable tabel;
		string sql;
		koneksi classKoneksi;
		
		public DataTable SimpanHasilJawaban(string id_soal,string id_kat,string no_soal,string id_matpel,string no,string inJwbn)
		{
			classKoneksi = new koneksi();
			sql = "call simpanJawaban("+id_soal+","+id_kat+","+no_soal+","+id_matpel+","+no+",'"+inJwbn+"')";
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
		
		public DataTable HitungKebenaranSoal(int id_kat,int no_soal, int no_induk, string pilih)
		{
			classKoneksi = new koneksi();
			sql = "call tampilHasilTesSementara("+id_kat+","+no_soal+","+no_induk+",'"+pilih+"')";
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
		
		public DataTable SimpanHasilAkhir(int id_kat,int id_matpel,int no_soal,int no,int salah,int benar,string hasil)
		{
			classKoneksi = new koneksi();
			sql = "call simpanHasil("+id_kat+","+id_matpel+","+no_soal+","+no+","+salah+","+benar+",'"+hasil+"')";
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
		
		public float HasilNilaiAkhir(int benar)
		{
			float hasil = Convert.ToSingle((benar*100)/20);
			return hasil;
		}
	}
}

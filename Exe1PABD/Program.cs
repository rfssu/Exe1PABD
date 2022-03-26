using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exe1PABD
{
    class Program
    {
        public void tPembeli()
        {
            string Id, Nama;

            Console.WriteLine("Input data Pembeli bakery\n");
            Console.Write("Masukkan Id Pembeli: ");
            Id = Console.ReadLine();

            Console.Write("Masukkan nama pembeli: ");
            Nama = Console.ReadLine();

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MYLEGION\\RAFI1;database=TokoRoti_Rafi;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Pembeli (id_Pembeli, Nama_Pembeli)" +
                    "values( '" + Id + "' , '" + Nama + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data ditambahkan");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void tBarang()
        {
            string kodeB, namaB;
            long HargaB;
            int Stok;

            Console.WriteLine("Input data pelanggan toko bakery\n");
            Console.Write("Masukkan Kode Barang: ");
            kodeB = Console.ReadLine();

            Console.Write("Masukkan nama Barang: ");
            namaB = Console.ReadLine();

            Console.Write("Masukkan Harga: ");
            HargaB = Convert.ToInt64(Console.ReadLine());


            

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MYLEGION\\RAFI1;database=TokoRoti_Rafi;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Barang(Kode_Barang, Nama_Barang, Harga_Barang, Stok_Barang)" +
                    "values( '" + kodeB + "' , '" + namaB + "', '" + HargaB + " ')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data ditambahkan");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void tKasir()
        {
            string id, nama;

            Console.WriteLine("Input data barang\n");
            Console.Write("Masukkan Id kasir): ");
            id = Console.ReadLine();

            Console.Write("Masukkan nama Kasir: ");
            nama = Console.ReadLine();


            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MYLEGION\\RAFI1;database=TokoRoti_Rafi;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Kasir(Id_Kasir, Nama_Kasir)" + "values" +
                    "( '" + id + "' , '" + nama + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data ditambahkan");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void tTransaksi()
        {
            string kodeT, date;
            int qty, total;

            Console.WriteLine("Input transaksi penjualan\n");
            Console.Write("Masukkan Id penjualan: ");
            kodeT = Console.ReadLine();


            Console.Write("Masukkan jumlah barang: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal transaksi: ");
            date = Console.ReadLine();

            Console.Write("Total Harga: Rp.  \n");
            total = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MYLEGION\\RAFI1;database=TokoRoti_Rafi;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Transaksi(Kode_Transaksi, Quantity, Tanggal_Transaksi, Total_harga)" +
                    "values( '" + kodeT + "' , " + qty + " , '" + date + "', " + total + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data ditambahkan");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
            int ch;
            Program p = new Program();

            Console.WriteLine("Aplikasi Pencatatan toko bakery\n");

            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Masukkan data Pembeli");
                Console.WriteLine("2. Masukkan data Barangy");
                Console.WriteLine("3. masukkan data Kasir");
                Console.WriteLine("4. Masukkan data Transaksi");
                Console.WriteLine("5. keluar\n");
                Console.Write("Pilih (1-5): ");

                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        {
                            p.tPembeli();
                        }
                        break;
                    case 2:
                        {
                            p.tBarang();
                        }
                        break;
                    case 3:
                        {
                            p.tKasir();
                        }
                        break;
                    case 4:
                        {
                            p.tTransaksi();
                        }
                        break;
                    case 5:
                        return;
                    default:
                        {
                            Console.WriteLine("Pilihan salah");
                            break;
                        }
                }

            }
        }
    }
}


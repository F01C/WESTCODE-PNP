using System;
namespace Latihan1MI2B
{
    public class Mahasiswa
    {
        private string nim;
        private string nama;

        //Objek Property
        public string Nim
        {
            get { return nim; }
            set { nim = value;}
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
    }
    public enum Hari { Senin, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu }

    class Program
    {
         static void Main(string[] args)
        { 
            // Type Value
            int a = 5;
            int b = a;
            a = 12;

            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");

            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "888888";
            mhs1.Nama = "Muhammad Zacky";
            Mahasiswa mhs2 = mhs1;

            Console.WriteLine($"Mahasiswa1 = NIM{mhs1.Nim}, Nama {mhs1.Nama}");
            Console.WriteLine($"Mahasiswa2 = NIM{mhs2.Nim}, Nama {mhs2.Nama}");
             mhs1.Nama = "Budi";
            Console.WriteLine($"Mahasiswa1 = NIM{mhs1.Nim}, Nama {mhs1.Nama}");
            Console.WriteLine($"Mahasiswa2 = NIM{mhs2.Nim}, Nama {mhs2.Nama}");

             var nama = "Muhammad Zacky";
             var bil1 = 10;
             var bil2 = 12.5;
             var isSelected = true;

             Console.WriteLine(nama.GetType().ToString());
             Console.WriteLine(bil1.GetType().ToString());
             Console.WriteLine(bil2.GetType().ToString());
             Console.WriteLine(isSelected);

             Hari tesHari = Hari.Senin;
             switch(tesHari)
             {
                 case Hari.Senin:
                     Console.WriteLine("Hari Senin");
                     break;

                 case Hari.Selasa:
                     Console.WriteLine("Hari Selasa");
                     break;

                 case Hari.Rabu:
                     Console.WriteLine("Hari Rabu");
                     break;

                 case Hari.Kamis:
                     Console.WriteLine("Hari Kamis");
                     break;

                 case Hari.Jumat:
                     Console.WriteLine("Hari Jumat");
                     break;

                 case Hari.Sabtu:
                     Console.WriteLine("Hari Sabtu");
                     break;

                 case Hari.Minggu:
                     Console.WriteLine("Hari Minggu");
                     break;
             }
             /*String nama ="";
             string alamat = string.Empty;
             Console.Write("")
            */
        }
    }
}

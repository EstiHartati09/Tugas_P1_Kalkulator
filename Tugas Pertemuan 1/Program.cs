using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menampilkan Judul Dan Menunya
            Console.WriteLine(" === Aplikasi Kalkulator ===");
            Console.WriteLine("Pilih menu Kalkulator: ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");



            Console.Write("Input nomor menu (1..4): ");
            string menu = Console.ReadLine();
            switch (menu)
            {


                case "1":
                    //Penambahan
                    Console.WriteLine();
                    Console.Write("Inputkan Nilai A : ");
                    int a = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Inputkan Nilai B : ");
                    int b = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine();
                    Console.Write("Hasil Penambahan : {0}", a + b);
                    Console.WriteLine();
                    break;


                case "2":
                    //Pengurangan
                    Console.WriteLine();
                    Console.Write("Inputkan Nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan Nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    Console.Write("Hasil Pengurangan : {0}", a - b);
                    Console.WriteLine();
                    break;


                case "3":
                    //Perkalian
                    Console.WriteLine();
                    Console.WriteLine("Input Nilai A :");
                    a = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Inputkan Nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    Console.Write("Hasil Perkalian : {0}", a * b);
                    Console.WriteLine();
                    break;




                case "4":
                    //Pembagian
                    Console.WriteLine();
                    Console.Write("Inputkan Nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Inputkan Nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    if (b != 0)
                    {


                        Console.Write("Hasil Pembagian : {0}",
                            Convert.ToDouble(a) / Convert.ToDouble(b));
                    }


                    else
                    {
                        Console.WriteLine("Pembagian nol tidak di perbolehkan");
                    }


                    Console.WriteLine();
                    break;


                default:
                    Console.WriteLine();
                    Console.Write("Maaf, menu yang di pilih tidak tersedia");
                    Console.WriteLine();
                    break;


            }


            Console.WriteLine("\nkeluar");
            Console.ReadKey();
        }
    }
}


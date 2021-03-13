using System;

namespace Kalkulator
{
    class Program
    {
        static void method(string[] args)
        {
        }
        static int tm (int a, int b){
            return a + b;
        }
        static int kr (int a, int b){
            return a - b;
        }
        static int kl (int a, int b){
            return a * b;
        }
        static int bg (int a, int b){
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            
            Console.WriteLine(" ");

            Console.WriteLine("   Menu Calculator   ");

            Console.WriteLine("+--------------------+");

            Console.WriteLine("|  1. Penambahan     |");
            Console.WriteLine("|  2. Pengurangan    |");
            Console.WriteLine("|  3. Perkalian      |");
            Console.WriteLine("|  4. Pembagian      |");

            Console.WriteLine("+--------------------+ ");

            Console.Write("\nSilahkan Inputkan Nilai");

            Console.Write("\n \t Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\t Nilai B = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(" ");

            Console.Write("\nSilahkan Inputkan Menu Calculator = ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan  " + a + " + " + b + " = " + tm (a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, kr (a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, kl (a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, bg (a, b));
                    break;
            }

            Console.WriteLine();
            if (menu > 4)
            {
                Console.WriteLine(" Maaf Menu yang Anda Pilih tidak Tersedia!");
            }
            else
            {

            }

            Console.WriteLine("\n Tekan Sembarang Key untuk Keluar");
            Console.ReadKey();
        }
    }
}
using System;

namespace BA_C_sharp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ÖRNEK : Ekrandan bir metin alacagiz.
            // Bu metin icerisinde kac adet sesli kac adet sessiz harf oldugunu tespit edecegiz.

            //Console.WriteLine("Lütfen metni giriniz!");
            //string cumle = Console.ReadLine().ToLower();

            //int sayacSesli = 0;

            //int sayacSessiz = 0;

            //char[] sesliler = { 'a', 'e', 'i', 'o', 'u' };

            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    for (int j = 0; j < sesliler.Length; j++)
            //    {
            //        if (cumle[i] == sesliler[j])
            //        {
            //            sayacSesli++;
            //            Console.WriteLine(sesliler[j]);
            //        }
            //    }
            //}

            //sayacSessiz = cumle.Length - sayacSesli;
            //Console.WriteLine("SESLI HARFLERIN SAYISI: " + sayacSesli.ToString());
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("SESSIZ HARFLERIN SAYISI: " + sayacSesli.ToString());

            //**********************************************
            //**********************************************

            // 2. ÖRNEK : sayilar dizisi olsun, bu dizinin icerisinden en büyük ve en kücük rakami bulan algoritmayi hesaplayiniz.

            Console.WriteLine("Dizi kac elemanli olsun:");
            int dizininElemanSayisi = int.Parse(Console.ReadLine());
            int[] numbers = new int[dizininElemanSayisi];

            for (int i = 0; i < numbers.Length; i++) // bu for döngüsünün amaci dizinin elemanlarini atamaktir.
            {
                Console.Write("Karsilastirilacak sayiyi giriniz: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //int[] numbers = { 10, 20, 66, 78, 1, 3, 9, 7898, 85, 36, 25, 88741 };

            int biggest = numbers[0];

            int smallest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }

                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("EN KÜCÜK SAYI : " + smallest);
            Console.WriteLine("*****************************");
            Console.WriteLine("EN BÜYÜK SAYI : " + biggest);

        }
    }
}

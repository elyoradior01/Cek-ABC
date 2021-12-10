using System;

namespace jumlah_kata_dalam_kalimat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blom Selesai
            Console.Write("INPUT KALIMAT: "); //ALL CAPS
            var words = Console.ReadLine();

            var spasi = words.IndexOf(' ');

            if (spasi < 1)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                words = Console.ReadLine();
            }
            Console.Write("INPUT KATA: ");
            var kata = Console.ReadLine();
            while (kata.Length <= 1)
            {
                Console.WriteLine("HURUF PADA KATA KURANG PANJANG");
                kata = Console.ReadLine();
            }
            Console.WriteLine("OUTPUT: \nSTATISTIK HURUF:");
            while (words.Length > 0)
            {
                if (words[0] != ' ')
                {
                    Console.Write($"{words[0]} = ");
                }
                int counter = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[0] == words[i])
                    {
                        counter++;
                    }
                }
                if (words[0] != ' ')
                {
                    Console.WriteLine(counter);
                }
                words = words.Replace(words[0].ToString(), string.Empty);
            }
            Console.WriteLine("\nJUMLAH HURUF:");
            int freq = words.Count();
            Console.Write(words.Length);
        }
    }
}
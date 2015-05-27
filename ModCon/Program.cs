using System;

using System.IO;

namespace ModCon
{
    class Program
    {
       
        static void Main(string[] args)
        {

            var c = new Random();
            var b=new decimal[200];
            var file = new FileStream("TextRandMassiv.txt", FileMode.Create); //создаем файловый поток
            var writer = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком 

                   
            for (var i = 0; i < 200; i++)

            {

                b[i] = c.Next();
                Console.WriteLine(b[i]);
                Console.WriteLine(new string('+', 35));
                writer.WriteLine(b[i]);
                writer.WriteLine(new string('+', 35));


            }
            writer.Close();
            Console.ReadKey();
        }
    }
}

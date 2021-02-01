using System;
using System.IO;

namespace Zak1
{
    class Program
    {
        private static int j;
        //Random rnd = new Random();
        //public static System.Collections.Generic.IEnumerable<int> Range(int 0, int 10);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Random rnd = new Random();
            //Console.Beep();
            int a = rnd.Next(1, 50);
            Console.WriteLine(a);
            string text = "";
            if (a >= 1 && a <= 10)
            {
                text = "--1111--";
            }
            else if (a >= 11 && a <= 20)
            {
                text = "--2222--";
            }
            else if (a >= 21 && a <= 30)
            {
                text = "--3333--";
            }
            else if (a >= 31 && a <= 40)
            {
                text = "--4444--";
            }
            else if (a >= 41 && a <= 50)
            {
                text = "--5555--";
            }
            Console.WriteLine(text);
            //switch (a)
            //{
            //case 1:
            //case 2:
            //case 3:
            //case 4:
            //case 5:
            //case 6:
            //case 7:
            //case 8:
            //case 9:
            //case 10:
            //text = "odin";
            //break;
            //case 1:
            //    text = "odin";
            //    break;
            //case 2: //when a >= 11 && a <= 20:
            //    text= "dva"; 
            //    break;
            //case 3: //when a >= 21 && a <= 30:
            //    text = "tri";
            //    break;
            //case 4: //when a >= 31 && a <= 40:
            //    text= "4etqre"; 
            //    break;
            //case 5: //when a >= 41 && a <= 50: 
            //    text = "pjat";
            //    break;
            //default:
            //    text = "Viga!";
            //    break;
            //}
            //Console.WriteLine(text);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace...");
                nupp = Console.ReadKey();
            }while (nupp.Key!=ConsoleKey.Backspace);
            StreamWriter file = new StreamWriter(@"..\..\text.txt", true);
            file.WriteLine(text);
            file.Close();
            StreamReader filest = new StreamReader(@"..\..\text.txt");
            text = filest.ReadToEnd();
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Failist oli text:\n{0}", text);
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
            int[] numbers2 = new int[6];
            Random do_5 = new Random();
            for (int k=0; k < numbers2.Length; k++)
            {
                numbers2[k] = do_5.Next(1, 200);
            }
            foreach(int i in numbers2)
            {
                Console.Write(i);
            }
            int[,] numbers3 = new int [4,10];
            for(int i=0; i < numbers3.GetLength(0); i++)
            {
                for (int j = 0 ; j < numbers3.GetLength(1); j++)
                {
                    numbers3[i, j] = 1;
                    Console.Write(numbers3[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

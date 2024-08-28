using System;
using System.Globalization;
namespace timkytu{
    class Program{
        private static bool count;

        static void Main(string[] Args){
            Console.WriteLine("nhap vao: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine("nhap ky tu can tim: ");
            char chu = Console.ReadKey().KeyChar;
            Console.WriteLine();

            chuoi = chuoi.Replace(" ", string.Empty);

             Console.WriteLine("So lan ky tu xuat hien la: " + Dem(chuoi, chu));
        }

         static int Dem(string mess, char kytu){
         int count = 0;
         for(int i = 0; i < mess.Length; i++)
         {
           if(kytu == mess[i])
           {
            count++;
           }
         }
         return count;
            
            
          }
        }
    }


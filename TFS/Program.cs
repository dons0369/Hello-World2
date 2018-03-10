using System;

namespace TFS
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Enter the Number");
         int i = int.Parse(Console.ReadLine());

         while (i > 0)
         {
            Console.WriteLine(i);
            i = i - 2;
         }
      }
   }
}

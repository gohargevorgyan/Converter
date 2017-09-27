using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program :Methods
    {
        static void Main(string[] args)
        {

          

            Console.WriteLine("Enter 1,2,3 or 4 ,where.");
            Console.WriteLine("1.km to ...");
            Console.WriteLine("1.sm to ...");
            Console.WriteLine("1.dm to ...");
            Console.WriteLine("1.sm to ...");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number!");
          double number = double.Parse(Console.ReadLine());
          double dm = 1;
          double sm=1;
          double m = 1;
            if (value == 1)
            {

             dm = Methods.ConvertKilometrToDecimeter(number);
              m = Methods.ConvertKilometrToMetr(number);
              sm = Methods.ConvertKilometrToSantimeter(number);
              
            }
            Console.WriteLine("---------------");
            Console.WriteLine("This is your values ! {0} dm ,{1} m,{2} sm ", dm,m,sm );
            Console.ReadLine();

            

        }
    }
}



/*  Console.WriteLine("Enter 1,2,3 or 4 ,where.");
            Console.WriteLine("1.km to ...");
            Console.WriteLine("1.sm to ...");
            Console.WriteLine("1.dm to ...");
            Console.WriteLine("1.sm to ...");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number!");
          double number = double.Parse(Console.ReadLine());
            Methods.Convert_Kilometr_To(number);
            
            
           Dictionary<int, Methods> students = new Dictionary<int, Methods>()
            {
                // other
            };
            */
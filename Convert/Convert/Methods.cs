using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Methods
    {
       

       public static int ConvertKilometrToMetr(int arg)
        {
            
            return arg * 1000;
               
        }
        public static double ConvertKilometrToMetr(double arg)
        {

            return arg * 1000;

        }


        public static int ConvertKilometrToSantimeter(int arg)
        {

            return arg * 100000;

        }
        public static double ConvertKilometrToSantimeter(double arg)
        {

            return arg * 100000;

        }


        public static int ConvertKilometrToDecimeter(int arg)
        {

            return arg * 10000;

        }
        public static double ConvertKilometrToDecimeter(double arg)
        {

            return arg * 10000;

        }
        


        
    }
}

/* public static void Convert_Kilometr_To(int arg)
        {
            var map = new Dictionary<int, int>();

            map.Add(arg, arg*1000);
            int arg1 = arg / 1000;
            map.Add(arg1, arg*10000);
            int arg2 = arg / 10000;
            map.Add(arg2, arg*100000);
            foreach (var i in map)
        {
          int  key = i.Key;
          int  value = i.Value;
          Console.WriteLine("{0} m ,{1} dm ,{2} sm ",key + "/" + value);
        }
         
        }
        public static void Convert_Kilometr_To(double arg)
        {
            var map = new Dictionary<double, double>();

            map.Add(arg, arg * 1000);
            map.Add(arg, arg * 10000);
            map.Add(arg, arg * 100000);
            foreach (var i in map)
            {
           double key = i.Key;
           double value = i.Value;
                Console.WriteLine("{0} m ,{1} dm ,{2} sm ", key + "/" + value);
            }

        }*/
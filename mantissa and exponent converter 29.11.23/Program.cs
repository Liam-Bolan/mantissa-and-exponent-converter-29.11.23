using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantissa_and_exponent_converter_29._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mant;
            string exp;
            bool expvalid = true;
            bool mantissaValid = true;

            do
            {
                Console.Write("Please enter an 8 bit Mantissa starting with '01' or '10': ");
                mant = Console.ReadLine();


                if (mant[0] == mant[1])
                {
                    Console.WriteLine("\nMant is not normalised!\n");
                    mantissaValid = false;
                }
                if (mant.Length != 8)
                {
                    Console.WriteLine("\nMant is not the right length!\n");
                    mantissaValid = false;
                }
            }
            while (mantissaValid == false);

            do
            {
                Console.Write("\nEnter a 4 bit exponent: ");
                exp = Console.ReadLine();
                
                if(exp.Length != 4)
                {
                    Console.Write("\nExp is not the right length!");
                    expvalid = false;
                }
            }
            while (expvalid == false);


            while (mantissaValid == true && expvalid == true)
            {
                int mv = Convert.ToInt32(mant, 2);
                double mantv = (double)mv * Math.Pow(2, -7);
                string mantstripped = mant.Substring(1, 7);
            }
            




        }
    }
}

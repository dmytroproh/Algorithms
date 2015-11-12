using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDivisiors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas, input number:");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            List<int> listOfDivisiors = new List<int>();
            GetDivisiors(InputNumber, listOfDivisiors);
            Console.WriteLine("Divisiors: ");
            foreach (var item in listOfDivisiors)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
            

            public static void GetDivisiors(int InputNumber,  List<int> listOfDivisiors)
            {
                if (InputNumber != 0)
                {
                    for (int i = 1 ; i <= (int)Math.Sqrt(Math.Abs(InputNumber)); i++)
                    {
                        if (InputNumber % i == 0)
                        {
                            listOfDivisiors.Add(i*Math.Sign(InputNumber));
                            if (!listOfDivisiors.Contains(InputNumber/i))
                                listOfDivisiors.Add(InputNumber / i );
                        }
                    }
                }
                else 
                { 
                    listOfDivisiors.Add(0);
                }         
            listOfDivisiors.Sort();
            }
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheLongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> list = new List<byte>();        
            string path = FileGenerator.Create();
            string byteStryng = File.ReadAllText(path);   
    
            foreach (char symbol in byteStryng)   
               list.Add((byte)Char.GetNumericValue(symbol));
            
            int logestSequenceValue = FindLongest(list);
            FileGenerator.Save(logestSequenceValue);

        }

        private static int FindLongest(List<byte> list)
        {
            int result = 0;
            int maxValue = 0;
            foreach (byte arr in list)
            {
                result = result * arr + arr;
                if (result > maxValue)
                    maxValue = result;

            }
            return maxValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheLongestSequence
{
   static class FileGenerator
    {
       public static string Create() {
         
           var input = new FileInfo("input.txt");         
           StreamWriter writer = input.CreateText();
           Random rand = new Random();
           for (int i = 0; i < rand.Next(50,100); i++)
           {
               writer.Write((byte)rand.Next(0, 2));  
           }
           writer.Close();
          
           return input.FullName;
       }
       public static void Save(int longestValue)
       {
           FileInfo output = new FileInfo("output.txt");
           StreamWriter writer = output.CreateText();
           writer.Write(longestValue);
           writer.Close();
          
       }
    }
}

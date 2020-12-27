using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"";
            string target = @"";


            File.Create(source);
            File.Copy(source, target);
            File.Move(source, target);
            File.Delete(source);

            //string[] lines = { "","","" };
            
            string[] lines = File.ReadAllLines(target);
            string text = "";

            //File.WriteAllLines(target, lines);
            File.WriteAllText(target, text);
            foreach (var item in lines)
            {
                text += "\t" + item;
            }

            File.ReadAllText(target);
            

        }
    }
}

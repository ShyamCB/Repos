using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter a function:\n1.DocumentFill\n2.SendForSign\n");
            string fn=Console.ReadLine();
            WindowsServiceLender.Service1 sv = new WindowsServiceLender.Service1();
            string ret=sv.Ondebug(fn);

            Console.WriteLine("OUTPUT:"+ret);
            Console.ReadLine();
             
        }

    
            }
        }
    


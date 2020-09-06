using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;


namespace Generate
{

    class Program3
    {
        public void ReadSample()
        {
            
        }

        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);





        }
    }
}

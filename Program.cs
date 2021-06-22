using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. 
// It is generally used when a method returns multiple values.
//f you want to use an out parameter, then you need to explicitly specify the out keyword in both the calling method and method definition.

namespace OutParameter
{
    class Program
    {
        static void Main()
        {
            Employee(out string ename, out int eroll, out string egender);
            Console.WriteLine("ename{0},eroll{1}, egender{2}", ename, eroll, egender);
            Console.ReadLine();
        }

        //create 1 statc method
        static void Employee(out string ename, out int eroll, out string egender)
        {
            ename = "roshi";
            eroll = 20;
            egender = "female";

        }
    }
}

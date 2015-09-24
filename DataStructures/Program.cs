using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace SvMicroSolutions.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
           LinkedList<string> list = new LinkedList<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");

            list.ListNodes();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Deleting node 8");
            list.Delete(8);
            list.ListNodes();

            Console.WriteLine();
            Console.WriteLine("Position 5: " + list.Retrieve(5).Data);

            Console.WriteLine();
            Console.WriteLine("Deleting node 5");
            list.Delete(5);

            Console.WriteLine();
            Console.WriteLine("Position 5: " + list.Retrieve(5).Data);

            Console.WriteLine();
            list.ListNodes();

            Console.WriteLine("Deleting node 9");
            list.Delete(9);
            Console.WriteLine();
            list.ListNodes();

            Console.WriteLine("Deleting node 1");
            list.Delete(1);
            Console.WriteLine();
            list.ListNodes();

            Console.WriteLine("Deleting node 1");
            list.Delete(1);
            Console.WriteLine();
            list.ListNodes();

            Console.ReadLine();



        }
    }
}

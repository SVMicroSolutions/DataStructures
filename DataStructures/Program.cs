using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            list.Add("C");
            list.Add("B");
            list.Add("A");


            list.ListNodes();
            Console.WriteLine();

          
         
          
            Console.WriteLine("reversing list");
            var reversedList = list.Reverse();
            Console.WriteLine();
            reversedList.ListNodes();
            Console.WriteLine();

            Console.WriteLine("get item that is 4 from last");
            Console.WriteLine(list.FetchData(4));
            Console.WriteLine();

            Console.ReadLine();

        }


    }
}

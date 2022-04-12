using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome To The Hash Tables Program-=-=-=-=-=");

            //Object of class MyMapNode
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);

            //Add data
            myMapNode.Add("0", "To");
            myMapNode.Add("1", "be");
            myMapNode.Add("2", "or");
            myMapNode.Add("3", "not");
            myMapNode.Add("4", "to");
            myMapNode.Add("5", "be");

            //Get Value and Display
            string hash5 = myMapNode.Get("5");
            Console.WriteLine("5th index  value: " + hash5);

            //Get Value and Display
            string hash2 = myMapNode.Get("2");
            Console.WriteLine("2nd index  value: " + hash2);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasBasicas
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista myList = new Lista();
            myList.Initialize(10);
            myList.InsertFirst(40);
            myList.InsertFirst(20);
            myList.InsertLast(12);
            Console.ReadLine();
        }
    }
}

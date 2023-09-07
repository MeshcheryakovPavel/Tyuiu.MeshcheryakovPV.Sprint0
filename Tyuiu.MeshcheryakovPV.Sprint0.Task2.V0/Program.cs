using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MeshcheryakovPV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MeshcheryakovPV.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метожа GetMessage
            // из библиотеки Tyuiu.MeshcheryakovPV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Павел"));
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint0.TaskReview.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение  переменной x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(x + y + z)*5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}

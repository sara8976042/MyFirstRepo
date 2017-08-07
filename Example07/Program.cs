using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入National No:");
            string nationalNo = Console.ReadLine();
            Console.Write("請輸入Type:");
            string Type = Console.ReadLine();
            Console.Write("請輸入Species:");
            string Species = Console.ReadLine();
            Console.Write("請輸入Height:");
            string Height = Console.ReadLine();
            Console.Write("請輸入Weight:");
            string Weight = Console.ReadLine();
            Console.Write("請輸入Abilities:");
            string Abilities = Console.ReadLine();
            Console.Write("請輸入Local No: ");
            string LocalNo = Console.ReadLine();
            Console.Write("請輸入Japanese:");
            string Japanese = Console.ReadLine();

            Console.WriteLine("您輸入的資料如下：");
            Console.WriteLine("National No:{0}",nationalNo);
            Console.WriteLine("Type:{0}", Type);
            Console.WriteLine("Species:{0}", Species);
            Console.WriteLine("Heigh:{0}", Height);
            Console.WriteLine("Weight:{0}", Weight);
            Console.WriteLine("Abilities:{0}", Abilities);
            Console.WriteLine("Local No:{0}", LocalNo);
            Console.WriteLine("Japanese:{0}", Japanese);
          
        }
    }
}

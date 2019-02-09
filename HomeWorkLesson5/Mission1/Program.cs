using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {


            //while (true)
            //{

            //    string login = Console.ReadLine();

            //    bool access = NotRegular.Not(login);
            //    if (access == true)
            //    {
            //        Console.WriteLine("Логин корректный");
            //    }
            //    else Console.WriteLine("Логин не корректный");

            //}

            while (true)
            {


                string login = Console.ReadLine();
                bool reg = Regex.IsMatch(login, @"^[\D]{1,}[A-Za-z0-9]{2,9}");
                if (reg == true)
                {
                    Console.WriteLine("Логин корректный");
                }
                else Console.WriteLine("Логин не корректный");

            }
            Console.ReadKey();

        }
    }
}

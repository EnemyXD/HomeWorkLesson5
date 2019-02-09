using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Калмыков
//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {


            //без использования регулярных выражений
            

                string login = Console.ReadLine();

                bool access = NotRegular.Not(login);
                if (access == true)
                {
                    Console.WriteLine("Логин корректный");
                }
                else Console.WriteLine("Логин не корректный");

            


            //с использованием регулярных выржений


             
                bool reg = Regex.IsMatch(login, @"^[\D]{1,}[A-Za-zА-Яа-я0-9]{2,9}");
                if (reg == true)
                {
                    Console.WriteLine("Логин корректный");
                }
                else Console.WriteLine("Логин не корректный");

            
            Console.ReadKey();

        }
    }
}

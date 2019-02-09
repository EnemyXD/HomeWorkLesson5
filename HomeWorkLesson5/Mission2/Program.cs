using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков

    //Разработать класс Message, содержащий следующие статические методы для обработки
//текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Console.WriteLine(String.Join(" ", text.Split().Where(x => x.Length <= 7)));

            Console.WriteLine(String.Join(" ", text.Split().Where(x => x[x.Length - 1] != 'й')));
                                  

            Console.ReadKey();

        }

    }
    
}

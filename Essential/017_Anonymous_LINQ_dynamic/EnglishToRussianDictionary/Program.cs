using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToRussianDictionary
{
    class Program
    {
        static IEnumerable GenerateDictionary()
        {
            yield return new { Eng = "book", Rus = "книга" };
            yield return new { Eng = "train", Rus = "поезд" };
            yield return new { Eng = "banana", Rus = "банан" };
            yield return new { Eng = "dictionary", Rus = "словарь" };
            yield return new { Eng = "table", Rus = "стол" };
            yield return new { Eng = "computer", Rus = "компьютер" };
            yield return new { Eng = "car", Rus = "автомобиль" };
            yield return new { Eng = "notebook", Rus = "записная книжка" };
            yield return new { Eng = "laptop", Rus = "ноутбук" };
            yield return new { Eng = "button", Rus = "кнопка" };
        }

        static void Main(string[] args)
        {
            var dict = GenerateDictionary();
            var orderedDIct = from dynamic word in dict
                              select new { Eng, Rus };

            foreach (dynamic item in GenerateDictionary())
            {
                Console.WriteLine($"{item.Eng} : {item.Rus}");
            }
        }
    }
}

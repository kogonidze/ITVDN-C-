using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDictionary
{
    class Dictionary
    {
        private const int dictionaryLength = 10;

        private string[] eng = new string[dictionaryLength];
        private string[] rus = new string[dictionaryLength];
        private string[] blr = new string[dictionaryLength];

        public Dictionary()
        {
            eng[0] = "book"; rus[0] = "книга"; blr[0] = "кнiга";
            eng[1] = "house"; rus[1] = "дом"; blr[1] = "хата";
            eng[2] = "sun"; rus[2] = "солнце"; blr[2] = "сонейка";
            eng[3] = "car"; rus[3] = "машина"; blr[3] = "машына";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= eng.Length - 1)
                {
                    return $"{eng[index]} - {rus[index]} - {blr[index]}";
                }
                else
                {
                    return "You are trying to go beyound the bounds of the array";
                }
            }
        }

        public string this[string word]
        {
            get
            {
                for (int index = 0; index < dictionaryLength; index++)
                {
                    if (eng[index] == word)
                    {
                        return $"{eng[index]} - {rus[index]} - {blr[index]}";
                    }
                    if (rus[index] == word)
                    {
                        return $"{eng[index]} - {rus[index]} - {blr[index]}";
                    }
                    if (blr[index] == word)
                    {
                        return $"{eng[index]} - {rus[index]} - {blr[index]}";
                    }
                }

                return "There is no such word in dictionary!";
            }
        }
    }
}

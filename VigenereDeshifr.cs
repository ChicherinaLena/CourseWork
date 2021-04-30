using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCourseWork
{
    class VigenereDeshifr
    {
        private static char[] characters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
            'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
            'э', 'ю', 'я'};

        private static int n = characters.Length;
        //создание ключа
        private static string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }
        //дешифровать
        public static string Deshifr(string input, string keyword)
        {
            input = input.ToLower();
            keyword = GetRepeatKey(keyword, input.Length);
            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                if (characters.Contains(symbol))
                {
                    int c = (n + Array.IndexOf(characters, symbol) + (-1) * Array.IndexOf(characters, keyword[keyword_index])) % n;

                    result += characters[c];

                    keyword_index++;
                }


                else
                {
                    result += symbol;
                }
            }

            return result;
        }
    }
}

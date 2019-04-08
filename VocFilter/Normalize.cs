using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocFilter
{
    static class Normalize
    {
        public static string GetLettersAndSpaces(string text)
        {
            string newtext = "";
            string outtext = "";
            //оставляет только буквы
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text, i)||text[i]==' ')
                    newtext += text[i];
            }
            //приводит к нижнему регистру
            for (int i = 0; i < newtext.Length; i++)
            {
                if (Convert.ToChar(newtext[i]) >= 'A' && Convert.ToChar(newtext[i]) <= 'Я')
                    outtext += Convert.ToString((Convert.ToChar(Convert.ToChar(newtext[i]) + 32)));
                else
                    outtext += newtext[i];
            }
            return outtext;
        }

        //получает список слов из текста
        public static List<string> GetWordList(string text)
        {
            List<string> wordlist=new List<string>();
            string word = "";
            for (int i = 0; i < text.Length; i++)
            {
                //собирает слово по-буквам
                if (text[i] != ' ')
                    word += text[i];
                else
                {
                    //добавляет слово в лист
                    wordlist.Add(word);
                    word = "";
                }
            }
            return wordlist;
        }
    }
}

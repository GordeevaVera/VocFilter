using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocFilter
{
    class BoytshovHeshingBySign
    {
        static List<string> vocabulary;
        static string[,] alphabet= 
            {
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "а", "д", "с", "е", "ъ", "ш", "г", "л", "б", "ф", "ж", "ч", "н" },
                { "о", "т", "з", "и", "ь", "щ", "к", "м", "п", "х", "й", "ю", "в" },
                { " ", " ", " ", "э", "ы", "у", "я", "", "", "ц", "ё", "р", "" }
            };

        //поиск похожих слов
        static public List<string> FamWords(string word)
        {
            List<string> wordlist=null;
            wordlist = Serach(GetHesh(CreateSign(word)));
            return wordlist;

        }

        //создание словаря
        public static List<string> CreateVoc()
        {
            string[] list = { "хух", "пербить", "киза"};
            List<string> wordlist = new List<string>(list);
            return wordlist;
        }

        //создание сигнатуры
        static string CreateSign(string word)
        {
            string sign = "";
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 13; j++)
                {
                    if (word.Contains(alphabet[i, j]))
                    {
                        alphabet[0, j] = "1";
                        j++;
                        i = 1;
                    }
                }
            for (int i = 0; i < 13; i++)
            {
                sign = alphabet[0, i];
            }
            return sign;
        }

        //хэширование
        static double GetHesh(string sign)
        {
            double hesh = 0;
            for (int i = 0; i < sign.Length; i++)
                hesh = Convert.ToInt32(sign[i]) * Math.Pow(2, i);
            return hesh;
        }

        //сравнение
        static List<string> Serach(double hesh)
        {
            List<string> reslist = new List<string>();
            reslist = null;
            for (int i = 0; i < vocabulary.Count; i++)
                if (Convert.ToInt32(vocabulary[i]) - hesh <= 2)
                    reslist.Add(vocabulary[i]);
            return reslist;
        }

    }
}

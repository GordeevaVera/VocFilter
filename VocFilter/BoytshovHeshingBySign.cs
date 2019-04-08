using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocFilter
{
    class BoytshovHeshingBySign
    {
        static List<double> vocabulary = new List<double>();
        static string[,] alphabet= 
            {
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "а", "д", "с", "е", "ъ", "ш", "г", "л", "б", "ф", "ж", "ч", "н" },
                { "о", "т", "з", "и", "ь", "щ", "к", "м", "п", "х", "й", "ю", "в" },
                { " ", " ", " ", "э", "ы", "у", "я", "", "", "ц", "ё", "р", "" }
            };

        //поиск похожих слов
        static public List<double> FamWords(string word)
        {
            List<double> wordlist=null;
            CreateVoc();
            wordlist = Serach(GetHesh(CreateSign(word)));
            return wordlist;

        }

        //создание словаря
        public static void CreateVoc()
        {
            List <string> wordlist = new List<string>();
            wordlist.Add("0000010001000");
            wordlist.Add("0101100010010");
            wordlist.Add("1011001000000");
            for (int i=0; i<wordlist.Count; i++)
            {
                vocabulary.Add(GetHesh(wordlist[i]));
            }
            vocabulary = new List<double>(vocabulary);
        }

        //создание сигнатуры
        static string CreateSign(string word)
        {
            string sign = "";
            for (int i = 1; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    if (word.Contains(alphabet[i, j]))
                    {
                        alphabet[0, j] = "1";
                    }
                }
            for (int i = 0; i < 13; i++)
            {
                sign += alphabet[0, i];
            }
            return sign;
        }

        //хэширование
        static double GetHesh(string sign)
        {
            double hesh = 0;
            for (int i = 0; i < sign.Length; i++)
                if (sign[i]!='0')
                        hesh = Convert.ToInt32(sign[i]) * Math.Pow(2, i);
            return hesh;
        }

        //сравнение
        static List<double> Serach(double hesh)
        {
            List<double> reslist = new List<double>();
            reslist = null;
            for (int i = 0; i < vocabulary.Count; i++)
                if (vocabulary[i] - hesh <= 2)
                    reslist.Add(vocabulary[i]);
            return reslist;
        }

    }
}

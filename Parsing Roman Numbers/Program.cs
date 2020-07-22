using System;
using System.Collections.Generic;
using System.Text;

namespace Parsing_Roman_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableNums = new Dictionary<char, int>()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };


        }
        static int CollectArabicNumbers()
        {
            // TODO: Написать функцию которая соберает результат конвертации римских чисел.
            return default;
        }

        static List<int> GetArabicNums()
        {
            // TODO: Написать функицю которая используя  ConvertRomanNumsToArabiсNums и
            //  RecognizeRomansNums получает список арабских чисел.
            return default;
        }

        static string RecognizeRomansNums(string romanNums)
        {
            // TODO: Написать функцию которая обнаруживает римское число и возвращает его.
            return default;
        }

        /* ==========================================================================================
         *                  Конвертировать римские числа в арабские числа
         * ==========================================================================================
        */
        static int ConvertRomanNumsToArabiсNums(Dictionary<char, int> tableNums, string romanNums)
        {
            // TODO: написать функцию которая берет римское число и конвертирует его в арабское.
            return default;
        }

        static bool CompareNumbers(int arabianNumbers, int romanNumbers)
        {
            // TODO: Реализовать сравнение.
            return false;
        }
       


    }
}

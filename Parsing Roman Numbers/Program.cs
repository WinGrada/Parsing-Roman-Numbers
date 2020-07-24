using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Parsing_Roman_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanToInt = new Dictionary<char, int>()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
            char[] tableRomanNums = new char[7] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

            Console.WriteLine(IsJustRomanNums(tableRomanNums, "XMMVII"));

        }
        /* ==========================================================================================
         *                  Конвертировать строку в список.
         * ==========================================================================================
         * GetListOfNums
         * 
         * 
        */
        static List<int> ConvertStrToList(Dictionary<char, int> tableNums, string romanNums)
        {
            var listOfNums = new List<int>();
            int arabicNum = 0;

            foreach (char romanSym in romanNums)
            {
                arabicNum = ConvertRomanNumToArabiсNum(tableNums, romanSym);
                listOfNums.Add(arabicNum);
            }

            return listOfNums;
        }

        /* ==========================================================================================
         *                  Соберает Арабское число из массива чисел.
         * ==========================================================================================
         * ConvertListNumsToNumByRomanRules
         * 
         * На вход получает массив чисел, из массива чисел соберает число по правилам римских чисел.
         * - если большое число стоит перед меньшей, то они складываются (принцип сложения),
         * - если меньшее число стоит перед большей, то меньшая вычитается из большей (принцип вычитания).
        */

        static int ConvertListNumsToNumByRomanRules(List<int> nums)
        {
            int result = 0;
            int sizeList = nums.Count;

            for (int i = 0; i < sizeList; i++)
            {
                //-----> Принцип вычитания римских чисел.
                if (((i + 1) != sizeList) && nums[i] < nums[i + 1])
                {
                    result += (nums[i + 1] - nums[i]);
                    i++;
                }
                else
                {
                    //-----> Принцип сложения римских чисел
                    result += nums[i];
                }
            }
            return result;
        }


        /* ==========================================================================================
         *                  Конвертировать римские числа в арабские числа
         * ==========================================================================================
        */
        static int ConvertRomanNumToArabiсNum(Dictionary<char, int> tableNums, char romanNum)
        {
            return tableNums[romanNum];
        }

        /* ==========================================================================================
         *                  Это только Римские числа?
         * ==========================================================================================
         * IsJustRomanNums
         * 
         * На входе получает строку, которую прогоняет через циклы, в котором каждый символ проверяется
         *  на принадлежность римским числам, если символ принадлежит римскому числу, засчитывает 
         *  совпадение. В конце проверяет кол-во совпадений на размер входной строки, если эти значения
         *  равны. вернет TRUE, иначе вернут FALSE
         *  
         *  Использует переменные:
         *                          str - строка которая содержит римские числа.
        */
        static bool IsJustRomanNums(char[] tableRomanNums, string inputStr)
        {
            foreach (var symbol in inputStr)
            {
                if ( !(Array.Exists(tableRomanNums, element => element == symbol)) )
                    return false;
            }
            return true;
        }

    }
}

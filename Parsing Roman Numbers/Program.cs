using System;
using System.Collections.Generic;

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

            var test = ConvertStrToList(tableNums, "MMMMMCMXCIX");

            Console.WriteLine("Result CANF");
            Console.WriteLine(ConvertListNumsToNumByRomanRules(test));

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

            foreach(char romanSym in romanNums)
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

        //static string ValidateRomanNum

        /* ==========================================================================================
         *                  Конвертировать римские числа в арабские числа
         * ==========================================================================================
        */
        static int ConvertRomanNumToArabiсNum(Dictionary<char, int> tableNums, char romanNum)
        {
            return tableNums[romanNum];
        }



    }
}

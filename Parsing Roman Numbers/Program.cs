/* Программа конвертирует Римские числа в int 
 * Пример: XCI -> 91
 * 
 * Исключение: Программа не учитывает l за римское число 1(I)
*/

using System;
using System.Collections.Generic;

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

            string userRomanNums = Console.ReadLine();
            userRomanNums = userRomanNums.ToUpper();

            int arabicNum = default; 

            //-----> Выполнение программы.
            if (IsJustRomanNums(tableRomanNums, userRomanNums))
            {
                var listIntNums = ConvertRomanStrToListInt(romanToInt, userRomanNums);

                arabicNum = ConvertRomanListToInt(listIntNums);
            }

            Console.WriteLine($"Result Convert: {arabicNum}");  
        }

        /* ==========================================================================================
         *                  Конвертировать строку в список.
         * ==========================================================================================
         * ConvertRomanStrToListInt
         * 
         * На вход получает словарь(ключ = римское число, значение = Int) и строку римских чисел,
         *  Далее создается цикл, в цикле записывается int с помощью словаря,
         *  каждый результат в цикле записывается в список. в Конце возвращает сформированный список.
         * 
         * Использует переменные:
         *                  romanToInt - словарь, где ключ римское число, а значение = int
         *                  romanNums - строка с римскими числами.
        */
        static List<int> ConvertRomanStrToListInt(Dictionary<char, int> romanToInt, string romanNums)
        {
            var listOfNums = new List<int>();
            int arabicNum = 0;

            foreach (char romanSym in romanNums)
            {
                arabicNum = romanToInt[romanSym];
                listOfNums.Add(arabicNum);
            }

            return listOfNums;
        }

        /* ==========================================================================================
         *                  Соберает Арабское число из массива чисел.
         * ==========================================================================================
         * ConvertRomanListToInt
         * 
         * На вход получает массив чисел, из массива чисел соберает число по правилам римских чисел.
         * - если большое число стоит перед меньшей, то они складываются (принцип сложения),
         * - если меньшее число стоит перед большей, то меньшая вычитается из большей (принцип вычитания).
         * Возвращает результат конвертации.
         * 
         * Использует переменные:
         *              nums - список с целыми числами.
        */
        static int ConvertRomanListToInt(List<int> nums)
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
         *                  Это только Римские числа?
         * ==========================================================================================
         * IsJustRomanNums
         * 
         * На входе получает массив таблицы римских чисел и входную строку. Далее через цикл foreach
         *  проверяет, есть ли X символ строки в таблице римских чисел. Если нету прерывает цикл и 
         *  возвращает False. Иначе True.
         *  
         *  Использует переменные:
         *                          tableRomanNums = массив римских чисел
         *                                           {'I', 'V', 'X', 'L', 'C', 'D', 'M'}
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

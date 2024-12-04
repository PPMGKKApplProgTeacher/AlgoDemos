using System;
using System.Collections.Generic;

namespace PhoneNumberLetterCombinations
{
    /*
    Задача: Комбинации от букви за телефонен номер
    Даден е низ, съдържащ цифри от 2 до 9 включително. Върнете всички възможни комбинации от букви, които тези цифри могат да представляват. 
    Резултатът може да бъде върнат в произволен ред.

    Мапингът на цифри към букви (като този на бутоните на старите телефони) е следният:
    keyboard = {
        "2": "abc",
        "3": "def",
        "4": "ghi",
        "5": "jkl",
        "6": "mno",
        "7": "pqrs",
        "8": "tuv",
        "9": "wxyz"
    }

    Забележка: Цифрата 1 не се асоциира с никакви букви.

    Пример:
    Вход: "23"
    Изход: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]

    Примерни тестови случаи:
    Тест 1:
    Вход: "2"
    Очакван резултат: ["a", "b", "c"]

    Тест 2:
    Вход: "5"
    Очакван резултат: ["j", "k", "l"]

    Тест 3:
    Вход: "234"
    Очакван резултат: ["adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"]

    Тест 4:
    Вход: "78"
    Очакван резултат: ["pt", "pu", "pv", "qt", "qu", "qv", "rt", "ru", "rv", "st", "su", "sv"]

    Тест 5:
    Вход: ""
    Очакван резултат: []

    Ограничения:
    - Дължината на входния низ е между 0 и 4.
    - Низът съдържа само цифри от 2 до 9.
    */

    // Клас за рекурсивното решение
    public class RecursiveSolution
    {
        // TODO 
        
        public RecursiveSolution(string input)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
    }

    // Клас за решението с Backtracking
    class BacktrackingSolution
    {
        // TODO     
        
        public BacktrackingSolution(string input)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Тестове за извикване на решенията
            string input1 = "23";  // Очакван резултат: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]
            string input2 = "234"; // Очакван резултат: ["adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", ...]
            string input3 = "";    // Очакван резултат: []
            string input4 = "7";   // Очакван резултат: ["p", "q", "r", "s"]
            string input5 = "78";  // Очакван резултат: ["pt", "pu", "pv", "qt", "qu", "qv", "rt", "ru", "rv", "st", "su", "sv"]

            // Извикване на решенията (според Вашата имплементация)
            var reccursiveResult1 = new RecursiveSolution(input1);
            Console.WriteLine(reccursiveResult1.ToString());
            var backtrackingResult1 = new BacktrackingSolution(input1);
            Console.WriteLine(backtrackingResult1.ToString());
        }
    }
}

namespace finalVerificationWork
{
    using static System.Console;
    public class GamesWithArray
    {
        // Метод подсчитывает количество элементов в которых меньше 4 символов.
        // The method counts the number of elements whith less than 4 characters.
        // Parameter: string array
        // Return value: number of elements
        public static int CountingElNewArray(string[] arrayForWork)
        {
            int count = 0;
            int len = arrayForWork.Length;
            if (len == 0) return count;
            for (int i = 0; i < len; i++)
            {
                if (arrayForWork[i] == null) continue;
                if (arrayForWork[i].Length < 4)
                {
                    count++;
                }
            }
            return count;
        }

        //Метод создает массив с элементами меньше 4 символов из входного массива.
        //The method creates an array with elements less than 4 characters
        // from the input array.
        // Parametrs: string array, length of the new array.
        // Return value: new string array.
        public static string[] CreatingNewArray(string[] arrayForWork, int len)
        {
            string[] resutArray = new string[len];
            int lenArray = arrayForWork.Length;
            int j = 0;
            for (int i = 0; i < lenArray; i++)
            {
                if (arrayForWork[i] == null)
                {
                    continue;
                }
                if (arrayForWork[i].Length < 4)
                {
                    resutArray[j] = arrayForWork[i];
                    j++;
                }
            }
            return resutArray;
        }

        // Метод преобразовывает массив строк в форматированную для вывода строку.
        // The method convert an array of strings into a formatted string for output.
        // Parameters: string array.
        // Return value: string.
        public static string ConvertArrayToString(string[] arrayForWork)
        {
            string str = "[";
            int len = arrayForWork.Length;
            for (int i = 0; i < len; i++)
            {
                if (i < len - 1)
                {
                    str += $"\"{arrayForWork[i]}\", ";
                }
                else
                {
                    str += $"\"{arrayForWork[i]}\"";
                }
            }
            str += "]";
            return str;
        }

        // Метод подсчитывает количество элементов в строке, используя символ который разделяет элементы
        // друг от друга.
        // The method counts the number of elements in a row
        // using a symbol that separates the elements from each other.
        // Parameters: string, string with the symbol.
        // Return value: number of elements.
        public static int NumberOfElInString(string ar, string s)
        {
            int len = ar.Length;
            int count = 0;
            bool flag = false;
            for (int i = 0; i < len; i++)
            {
                if (ar[i] == s[0])
                {
                    flag = true;
                    continue;
                }
                if (flag)
                {
                    count++;
                    flag = false;
                }
            }
            return ++count;
        }

        // Метод преобразовывает строку в массив строк.
        // The method converts a string into an array of strings.
        // Parameters: string, string with the symbol.
        // Return value: array of strings
        public static string[] TranslatingIntoArray(string str, string s)
        {
            int len = NumberOfElInString(str, s);
            int lenStr = str.Length;
            string[] result = new string[len];
            int j = 0;
            bool flag = false;
            for (int i = 0; i < lenStr; i++)
            {
                if (str[i] != s[0])
                {
                    result[j] += str[i];
                    flag = true;
                }
                else
                {
                    if (flag)
                    {
                        j++;
                        flag = false;
                    }
                }
            }
            return result;
        }

        // Альтернативное решение, для сучая когда массив вводится в виде строки с клавиатуры.
        // Alternative solution for case when the array is entered from the keyboard.
        public static void AlternativeSolution()
        {
            WriteLine("Введите строку с элементами массива:");
            string sourceStr = ReadLine() ?? string.Empty;
            if (sourceStr == string.Empty)
            {
                WriteLine("[ ]");
                Environment.Exit(1);
            }

            WriteLine("Введите символ который разделяет строку на элементы:");
            string inputStr = ReadLine() ?? string.Empty;
            if (inputStr.Length != 1)
            {
                WriteLine($"Нужно ввести один символ, вы ввели {inputStr}");
                Environment.Exit(1);
            }

            int len = NumberOfElInString(sourceStr, inputStr);
            string[] arStr = TranslatingIntoArray(sourceStr, inputStr);
            len = CountingElNewArray(arStr);
            if (len == 0)
            {
                WriteLine("[ ]");
                Environment.Exit(1);
            }
            string[] tempArray = CreatingNewArray(arStr, len);
            sourceStr = ConvertArrayToString(arStr);
            string resultStr = ConvertArrayToString(tempArray);
            Write(sourceStr + " -> ");
            WriteLine(resultStr);
        }

        // Решение когда исходные данные вводятся из файла.
        // Solution when the source data is entered from file.
        // Parameters: file name, string with separating symbol.
        public static void SolutionWithFile(string fileName, string symbol)
        {
            string[] arrayStrTest = System.IO.File.ReadAllLines(fileName);
            string[] temp;
            int len = 0;
            string sourceStr = string.Empty;
            string resultStr = string.Empty;
            foreach (string line in arrayStrTest)
            {
                WriteLine("\t" + line);
                if (line.Length == 0)
                {
                    WriteLine("[ ]");
                    continue;
                }
                temp = TranslatingIntoArray(line, symbol);
                len = CountingElNewArray(temp);
                if (len == 0)
                {
                    WriteLine("[ ]");
                    continue;
                }
                sourceStr = ConvertArrayToString(temp);
                Write(sourceStr + " -> ");
                string[] result = CreatingNewArray(temp, len);
                resultStr = ConvertArrayToString(result);
                WriteLine(resultStr);
            }
        }
    }
}
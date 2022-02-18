namespace finalVerificationWork
{
    using static System.Console;
    public class GamesWithArray
    {
        public static int CountingElNewArray(string[] arrayForWork)
        {
            int count = 0;
            int len = arrayForWork.Length;
            for (int i = 0; i < len; i++)
            {
                if (arrayForWork[i].Length < 4)
                {
                    count++;
                }
            }
            return count;
        }

        public static string[] CreatingNewArray(string[] arrayForWork, int len)
        {
            string[] resutArray = new string[len];
            int lenArray = arrayForWork.Length;
            int j = 0;
            for (int i = 0; i < lenArray; i++)
            {
                if (arrayForWork[i].Length < 4)
                {
                    resutArray[j] = arrayForWork[i];
                    j++;
                }
            }
            return resutArray;
        }

        public static string ConvertArrayToString(string[] arrayForWork)
        {
            string str = "[ ";
            int len = arrayForWork.Length;
            for (int i = 0; i < len; i++)
            {
                if (i < len - 1)
                {
                    str += $"\"{arrayForWork[i]}\", ";
                }
                else
                {
                    str += $"\"{arrayForWork[i]}\" ";
                }
            }
            str += "]";
            return str;
        }

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
    }
}
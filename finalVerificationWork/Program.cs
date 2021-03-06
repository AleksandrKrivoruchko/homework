// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма.
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":)-"]
using static System.Console;
using static finalVerificationWork.GamesWithArray;

Clear();

//string[] sourceArray = { "empty.stirng" }; // Для вывода пустого массива

string[] sourceArray = { "hello", "2", "world", ":)-", "run", "for", "your", "job" };
// ******************** Массив задан изначально **************
int len = CountingElNewArray(sourceArray);
if (len == 0)
{
    WriteLine("[ ]");
    Environment.Exit(1);
}
string[] tempArray = CreatingNewArray(sourceArray, len);
string sourceStr = ConvertArrayToString(sourceArray);
string resultStr = ConvertArrayToString(tempArray);
Write(sourceStr + " -> ");
WriteLine(resultStr);
// ************************************************************

// ********* Для ввода массива с клавиатуры в виде строки *****
//AlternativeSolution();
// ************************************************************

//************ Для ввода исходных данных из файла *************
string fileName = "Program.cs";
SolutionWithFile(fileName, " ");
// ************************************************************
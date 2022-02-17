// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма.
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":)-"]
using static System.Console;
using static finalVerificationWork.GamesWithArray;

string[] sourceArray = { "hello", "2", "world", ":)-", "run", "for", "your", "job" };

int len = CountingElNewArray(sourceArray);
string[] tempArray = CreatingNewArray(sourceArray, len);
string sourceStr = ConvertArrayToString(sourceArray);
string resultStr = ConvertArrayToString(tempArray);
Write(sourceStr + " -> ");
WriteLine(resultStr);
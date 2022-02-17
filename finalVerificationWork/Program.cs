// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма.
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":)-"]
using static System.Console;
using static finalVerificationWork.GamesWithArray;

string[] sourceArray = { "hello", "2", "world", ":)-", "run", "for", "your", "job" };
WriteLine("[\"hello\", \"2\", \"world\", \":)-\"] -> [\"2\", \":)-\"]");
WriteLine(sourceArray[0].Length);
int len = CountingElNewArray(sourceArray);
WriteLine(len);
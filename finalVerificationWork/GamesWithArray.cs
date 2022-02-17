namespace finalVerificationWork
{
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
    }
}
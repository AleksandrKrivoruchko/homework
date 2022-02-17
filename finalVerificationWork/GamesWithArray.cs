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

        
    }
}
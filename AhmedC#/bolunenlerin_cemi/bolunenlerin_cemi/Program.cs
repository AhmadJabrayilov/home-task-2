using System;

namespace bolunenlerin_cemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3-e bolunen cemi

            int[] numbers = { 16, 23, 45, 89, 32, 12, 27 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%3==0)
                {
                    sum+=numbers[i];
                }
            }
            Console.WriteLine(sum);
            #endregion
        }
    }
}

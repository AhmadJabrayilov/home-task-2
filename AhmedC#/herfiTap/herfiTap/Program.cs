using System;

namespace herfiTap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region a herfi
            Console.WriteLine("Word: ");
            string word = "ahmad Jabrayilov";
            char search_letter = 'a';
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==search_letter)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
            #endregion


        }
    }
}

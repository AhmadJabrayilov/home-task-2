using System;

namespace mertebesayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mertebe sayi
            Console.WriteLine("ededi daxil edin:");
            int eded =Convert.ToInt32(Console.ReadLine());
            int numberFloor = 0;
            while (eded>0)
            {
                eded/=10;
                numberFloor++;
            }
            Console.WriteLine("ededin mertebe sayi: " + numberFloor);
            #endregion



        }
    }
}

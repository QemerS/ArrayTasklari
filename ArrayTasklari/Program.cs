using System;

namespace ArrayTasklari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task2: Total number of dublicates is: "+FindDublicate());
            //Console.WriteLine("Task3:" + Yoxla());
        }

        #region Task2
        static int FindDublicate() {
            byte[] array = { 7, 8, 3, 7, 4, 3, 5 };
            byte countOfDublicate = 0;

            for (int ilk = 0; ilk < array.Length; ilk++) {
                for (int iki = ilk + 1; iki < array.Length - 1; iki++) {
                    if (array[ilk] == array[iki])
                    {
                        countOfDublicate++;
                    }
                }
            } return countOfDublicate;
        }
        #endregion

        #region Task3
        static int verilmisEded = 0;
        static int[] array = { 1,2,3,4};
        static bool Yoxla()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == verilmisEded)
                {
                    return true;
                }
            }
            return false;
        }
            
    }
    #endregion
}

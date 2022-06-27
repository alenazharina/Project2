using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1,2,3,4,5,6};

            for (int index = myarray.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(myarray [index]);
            }

            
        }
    }
}

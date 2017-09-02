    using System;

namespace sample2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int count = 0;
            string input = Console.ReadLine();
            count = int.Parse(input);

            for (int y = 0; y < count; y++)
            {
                PrintLine(y);//함수설명쓰기

            }
            for (int y = count; y <= 0; y--)
            {
                PrintLine(z);//함수설명쓰기

            }



            static void PrintLine(int count)
            {
                for (int x = 0; x < count; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }
    }
}

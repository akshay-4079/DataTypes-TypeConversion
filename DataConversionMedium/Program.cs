using System;

namespace DataConversionMedium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion");
            int i = 345;
            float f = i;

            Console.WriteLine(f);

            float g = float.Parse("123.212");
            Console.WriteLine(g);
            int j = 100;
            uint u = (uint)j;
            Console.Write(j);
        }
    }
}

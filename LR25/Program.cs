using System;
using System.Collections.Generic;
using System.IO;


namespace LR25
{
    class Program
    {
        static void Main(string[] args)
        {
            double C;
            Queue<double> numbers = new Queue<double>();
            string filePath = "vvod.txt";
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
            {
                string line;
                double n;
                while ((line = sr.ReadLine()) != null)
                {
                    n = Convert.ToDouble(line);
                    numbers.Enqueue(n);
                }
            }
            foreach(double a in numbers)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
            Console.Write("Input С= ");
            C = Convert.ToDouble(Console.ReadLine());
            foreach (double a in numbers)
            {
                if (a<C) 
                {
                    Console.Write("Elements are smaller" + a);
                }
                Console.WriteLine();
                if (a > C) 
                {
                   
                    Console.Write("Elements more " + a);
                }
            }
            Console.ReadKey();
        }
    }
}

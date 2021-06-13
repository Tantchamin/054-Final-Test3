using System;

namespace _054_Final3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = new double[100];
            string inputNum = Console.ReadLine();
            double convert;
            int i = 0;
            double maximum = 0;
            double minimum = 0;
            double score = 0;
            double mean = 0;
            while (inputNum != "End")
            {
                convert = Convert.ToDouble(inputNum);
                number[i] = convert;
                i += 1;
                inputNum = Console.ReadLine();
            }

            string mode = Console.ReadLine();
            while (mode != "FindMax" && mode != "FindMin" && mode != "FindMean")
            {
                Console.WriteLine("Invalid Mode");
                mode = Console.ReadLine();
            }

            if (mode == "FindMax")
            {
                maximum = number[0];
                for (int z = 1; z < i; z++)
                {
                    if (maximum < number[z])
                    {
                        maximum = number[z];
                    }
                }
                Console.WriteLine(maximum);
            }
            else if (mode == "FindMin")
            {
                minimum = number[0];
                for (int x = 1; x < i; x++)
                {
                    if (minimum > number[x])
                    {
                        minimum = number[x];
                    }
                }
                Console.WriteLine(minimum);
            }
            else if (mode == "FindMean")
            {
                for (int c = 0; c < i; c++)
                {
                    score += number[c];
                }
                mean = score / i;
                Console.WriteLine(mean);
            }
                     
        }
    }
}

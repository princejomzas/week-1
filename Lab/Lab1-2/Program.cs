using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            // input

            int[] recv = input();
            process(recv);
        }

        public static int[] input()
        {
            int count;

            Console.Write("How many number ? : ");
            count = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[count];

            for (int i = 0; i < count; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            return number;
        }

        public static void process(int[] input)
        {
            bool flag = true;

            // process
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            output(input);
        }

        public static void output(int[] input)
        {
            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class HarmonicNumber
    {
        public void isHarmonic()
        {
            Console.WriteLine("Enter the num: ");
            int userInput = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i < userInput; i++)
            {
                sum = sum + (1 / i);
            }
            Console.WriteLine("Harmonic sum is " + sum);
        }
    }
}
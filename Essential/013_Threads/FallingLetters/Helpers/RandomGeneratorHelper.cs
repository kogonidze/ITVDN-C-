using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingLetters.Helpers
{
    public abstract class RandomGeneratorHelper
    {
        public static Random rand = new Random();
        public static char GenerateLetter()
        {
            return (char)rand.Next(97, 122);
        }

        public static int[] GenerateChainSizes()
        {
            var arrSizes = new int[Console.WindowWidth];

            for (int i = 0; i < arrSizes.Length; i++)
            {
                arrSizes[i] = rand.Next(3, 10);
            }

            return arrSizes;
        }

        public static int[] GenerateInitialSteps(int length)
        {
            var initialSteps = new int[Console.WindowWidth];

            for (int i = 0; i < length; i++)
            {
                initialSteps[i] = rand.Next(1, 20);
            }

            return initialSteps;
        }
    }
}

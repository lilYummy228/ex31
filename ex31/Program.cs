using System;

namespace ex31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;
            int[] array = new int[arraySize];

            GenerateValues(array, 0, 101);

            ShowArray(array);

            Shuffle(array);

            ShowArray(array);
        }

        static void GenerateValues(int[] array, int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
            int randomIndex;
            int shuffledElement;

            for (int i = 0; i < array.Length; i++)
            {
                randomIndex = random.Next(i, array.Length);
                shuffledElement = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = shuffledElement;
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

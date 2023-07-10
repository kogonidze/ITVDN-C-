namespace WorkWithArrayApp;

internal class MyArray
{
    private int[] array;

    public MyArray(int size)
    {
        array = new int[size];
        FillArray();
    }

    private void FillArray()
    {
        var random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MaxValue);
        }
    }

    public int Max()
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }

    public int Min()
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    public long Sum()
    {
        long sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    public double Average()
    {
        var sum = Sum();

        return (double) sum / array.Length;
    }

    public void PrintOddValues()
    {
        Console.WriteLine("Odd values: ");

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

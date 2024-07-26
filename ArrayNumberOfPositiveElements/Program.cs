class MainClass
{
    /// <summary>
    /// Calculating numbers of positive elements in Array
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        // 1-Dim Array --------
        int[] ints = { 1, -2, 3, -45, 87, 3, 4, 6 };
        int numOfPositiveElements = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > 0) numOfPositiveElements++;
        }
        Console.WriteLine(numOfPositiveElements);

        // 2-Dims Array --------
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        numOfPositiveElements = 0;

        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            {
                if (arr[i, j] > 0) numOfPositiveElements++;
            }
        }
        Console.WriteLine(numOfPositiveElements);
    }
}

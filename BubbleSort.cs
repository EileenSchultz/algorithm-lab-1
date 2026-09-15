public static class BubbleSort
{
    public static void BubSort(double[] vector)
    {
        for (int i = 0; i < vector.Length - 1; i++)
        {
            for (int j = 0; j < vector.Length - i - 1; j++)
            {
                if (vector[j] > vector[j + 1])
                {
                    double temp = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = temp;
                }
            }
        }
    }
}

// сложность алгоритма O(n) - в лучшем случае
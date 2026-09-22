public static class ProductFunction
{
    // сложность - O(n)
    // рекомендуемый - 30_000_000
    public static void Execute(double[] vector)
    {
        double product = 1.0;
        for (int i = 0; i < vector.Length; i++)
        {
            product *= vector[i];
        }
        System.GC.KeepAlive(product);
    }
}

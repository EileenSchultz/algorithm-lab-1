public static class ConstantFunction
{
    // сложность алгоритма -  O(1)
    // рекомендуемый максимум 50_000_000
    public static void Execute(double[] vector)
    {
        double result = 1.0;
        // защита от оптимизации компилятора
        System.GC.KeepAlive(result);
    }
}

public static class ClassicQuickPow
{
    // Классический быстрый алгоритм возведения в степень (Рис. 4)
    public static double CQPow(double x, int n)
    {
     
        double c = x;
        double f = 1;
        int k = n;
        
        // Если да, то заходим в тело цикла, если нет, то выходим к блоку f
        while (k != 0)
        {
            if (k % 2 == 0)
            {
                // Ветка да
                c = c * c;
                k = k / 2;
            }
            else
            {
                // Ветка нет
                f = f * c;
                k = k - 1;
            }

        }
        
        return f;
    }
}
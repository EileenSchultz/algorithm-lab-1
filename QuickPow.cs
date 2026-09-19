// Быстрое возведение в степень
public static class QuickPow
{
    public static double QPow(double x, int n)
    {
        double c = x;
        int k = n;
        double f;
        
        if (k % 2 == 1)
        {
            //если да
            f = c;
        }
        else
        {
            //если нет
            f = 1;
        }


        do
        {
            k = k / 2;
            c = c * c;
            
            if (k % 2 == 1)
            {
                f = f * c;
            }
            
        }
        while (k != 0);
        return f;
    }
}
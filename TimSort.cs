public static class TimSort
{
    // 32 - это стандартное значение, подобранное Тимом Питерсом 
    private const int RUN = 32;

    public static void TiSort(double[] vector)
    {
        if (vector == null || vector.Length == 0)
            return;

        int n = vector.Length; // получаем длину массива


        for (int i = 0; i < n; i += RUN) // проходимся по массиву с шагом RUN
        {
            int right = i + RUN - 1; // правая граница куска
            // это для того, если мы вшли за пределы массива, то просто обрезаем до последнего индекса
            if (right >= n) right = n - 1;

            InsertionSort(vector, i, right);
        }

        for (int size = RUN; size < n; size = 2 * size)
        {
            // left это начало блока
            // за одну итерацию сливаем ДВА блока.
            for (int left = 0; left < n; left += 2 * size)
            {
                // конец блока
                int mid = left + size - 1;

                // конец второго блока
                int right = left + 2 * size - 1;

                // Опять защита от выхода за границу масства
                if (mid >= n) mid = n - 1;
                if (right >= n) right = n - 1;

                // Есть ли 2й блок?
                if (mid < right)
                {
                    // Сливаем два отсортированных блока.
                    Merge(vector, left, mid, right);
                }
            }
        }
    }

    // метод сортировки вставками
    private static void InsertionSort(double[] vector, int left, int right)
    {
        // Проходим по части, начиная со второго элемента.
        for (int i = left + 1; i <= right; i++)
        {
            // Запоминаем текущий элемент, который потом переставим
            double temp = vector[i];
            int j = i - 1;

            while (j >= left && vector[j] > temp)
            {
                vector[j + 1] = vector[j]; // сдвигаем vector на 1 вправо, и освобождаем место для temp
                j--;
            }

            // правильная позиция для temp.
            vector[j + 1] = temp;
        }
    }

    // метод слияния отсортированных подмассивов
    private static void Merge(double[] vector, int l, int m, int r)
    {
        int len1 = m - l + 1; // длина левого куска
        int len2 = r - m; // длина правого куска

        //массивы для хранения копий
        double[] left = new double[len1];
        double[] right = new double[len2];

        // Копируем части массива во временный
        Array.Copy(vector, l, left, 0, len1);
        Array.Copy(vector, m + 1, right, 0, len2);


        int i = 0, j = 0, k = l;

        // пока массивы не пустые
        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                vector[k++] = left[i++]; // кладём left[i] и двигаем i и k вправо
            }
            else
            {
                vector[k++] = right[j++]; // кладём right[j] и двигаем j и k вправо
            }
        }

        // Если в левом массиве ещё остались элементы, то мы копируем их в vector
        while (i < len1)
            vector[k++] = left[i++];
        // Если в правом массиве ещё остались элементы,то мы копируем их в vector
        while (j < len2)
            vector[k++] = right[j++];
    }
}
using System.Numerics;

public static class QuickSort
{
    // запускаем сортирвку
    public static void QoiSort(double[] vector)
    {
        if (vector == null || vector.Length == 0)
            return;
            
        QuickSorts(vector, 0, vector.Length - 1);
    }

    // разбиваем массив
    private static int FindPivot(double[] vector, int minIndex, int maxIndex)
    {
        double pivotValue = vector[maxIndex]; // опорный элемент, мы берем последний
        int pivotIndex = minIndex - 1; // его индекс равен минимальный - 1

        for (int i = minIndex; i < maxIndex; i++) // ищем элементы меньше опорного
        {
            if (vector[i] < pivotValue) //если данный элемент меньше опорного
            {
                pivotIndex++;
                (vector[pivotIndex], vector[i]) = (vector[i], vector[pivotIndex]); // меняем их местами
                /*
                 * или же
                 * temp = vector[pivotIndex];
                 * vector[pivotIndex] = vector[i];
                 * vector[i] = temp; 
                 */
            }
        }

        // Ставим опорный элемент на его финальное место
        pivotIndex++;
        (vector[pivotIndex], vector[maxIndex]) = (vector[maxIndex], vector[pivotIndex]);
        /*
         * или же
         * temp = vector[pivotIndex];
         * vector[pivotIndex] = vector[maxIndex];
         * vector[maxIndex] = temp;
         */

        return pivotIndex;
    }

 
    private static void QuickSorts(double[] vector, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
            return;

        int pivot = FindPivot(vector, minIndex, maxIndex); // получаем индекс опорного элемента
        QuickSorts(vector, minIndex, pivot - 1); // вызываем функцию для подмассива до опорного эл-та
        QuickSorts(vector, pivot + 1, maxIndex); // это после опорного эл-та
        
    }
}


// сложность алгоритма O(n log (n)) - в лучшем случае


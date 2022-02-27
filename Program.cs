using System;

namespace SortingAlgorithumAnalysis
{
    public class Program
    {
        static void Main()
        {
            BubbleSortAnalysis sort = new BubbleSortAnalysis();

            int[] arr = { 23, 43, 12, 4, 53, 1, 6 };
            int[] ar = { 1, 2, 3, 4, 5 };
            sort.ShowArray(ar);
            sort.BubbleSort(ar);
            sort.ShowArray(ar);

        }
    }
}

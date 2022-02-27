using System;

namespace SortingAlgorithumAnalysis
{
    public class Program
    {
        static void Main()
        {
            BubbleSortAnalysis sort = new BubbleSortAnalysis();
            InsertionSortAnalysis insertion = new InsertionSortAnalysis();
            SelectionSortAnalysis selection = new SelectionSortAnalysis();
            QuickSortAnalysis quick = new QuickSortAnalysis();

            int[] arr = { 23, 43, 12, 4, 53, 1, 6 };
            int len = arr.Length;
            // int[] ar = { 1, 2, 3, 4, 5 };
            // BubbleSortAnalysis.ShowArray(ar);
            // sort.BubbleSort(ar);
            // BubbleSortAnalysis.ShowArray(ar);

            //insertion.InsertionSort(arr);
            //BubbleSortAnalysis.ShowArray(arr);
            // selection.SelectionSort(arr);

            quick.QuickSort(arr, 0, len - 1);

            BubbleSortAnalysis.ShowArray(arr);

        }
    }
}

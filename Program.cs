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

            int[] arr = { 23, 43, 12, 4, 53, 1, 6 };
            // int[] ar = { 1, 2, 3, 4, 5 };
            // BubbleSortAnalysis.ShowArray(ar);
            // sort.BubbleSort(ar);
            // BubbleSortAnalysis.ShowArray(ar);

            //insertion.InsertionSort(arr);
            //BubbleSortAnalysis.ShowArray(arr);
            selection.SelectionSort(arr);
            BubbleSortAnalysis.ShowArray(arr);

        }
    }
}

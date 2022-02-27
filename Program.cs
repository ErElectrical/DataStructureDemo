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
            mergeSortAnalysis merge = new mergeSortAnalysis();
            CountSortAnalysis count = new CountSortAnalysis();

            int[] arr = { 23, 43, 12, 4, 53, 1, 6 };
            //sort.BubbleSort(arr);
            int lenarr = arr.Length;

            bool flag = true;
            while(flag == true)
            {
                Console.WriteLine("Choose wisely to select for sorting technique" +
                                   "\n1. select for BubbleSort "+
                                   "\n2. select for insertionsort"+
                                   "\n3. select for selectionsort"+
                                   "\n4. select for quickSort" +
                                   "\n5. select for mergeSort"+
                                   "\n6. select for countsort"+
                                   "\n7. show Array "+
                                   "\n0. quit");
                int val = Convert.ToInt32(Console.ReadLine());
                switch(val)
                {
                    case 1:
                        sort.BubbleSort(arr);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 2:
                        insertion.InsertionSort(arr);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 3:
                        selection.SelectionSort(arr);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 4:
                        quick.QuickSort(arr, 0, lenarr - 1);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 5:
                        merge.MergeMaster(arr, 0, lenarr - 1);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 6:
                        count.Countsort(arr, lenarr);
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 7:
                        BubbleSortAnalysis.ShowArray(arr);
                        break;
                    case 0:
                        flag = false;
                        break;

                }
            }
            //int[] ar = { 435, 43, 10, 77, 2 };
            ////sort.BubbleSort(ar);
            //int lenar = ar.Length;
            //int[] sum = new int[lenar + lenarr - 1];

            //// int[] ar = { 1, 2, 3, 4, 5 };
            //// BubbleSortAnalysis.ShowArray(ar);
            //// sort.BubbleSort(ar);
            //// BubbleSortAnalysis.ShowArray(ar);

            ////insertion.InsertionSort(arr);
            ////BubbleSortAnalysis.ShowArray(arr);
            //// selection.SelectionSort(arr);

            //// quick.QuickSort(arr, 0, len - 1);

            //// merge.mergesort(arr, ar, sum, lenar, lenarr);

            ////merge.MergeMaster(arr, 0, lenarr - 1);

            //count.Countsort(arr, lenar);

            //BubbleSortAnalysis.ShowArray(arr);

        }
    }
}

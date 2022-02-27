using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{

    /// <summary>
    /// Analysis Of quick sort
    /// QuickSort is a Divide and Conquer algorithm.
    /// It picks an element as pivot and partitions the given array around the picked pivot.
    /// There are many different versions of quickSort
    /// that pick pivot in different ways. 
    ///like
    ///1.Always pick first element as pivot.
    ///2.Always pick last element as pivot(implemented below)
    ///3.Pick a random element as pivot.
    ///4.Pick median as pivot.
    ///The key process in quickSort is partition(). 
    ///Target of partitions is, given an array 
    ///and an element x of array as pivot,
    ///put x at its correct position in sorted 
    ///and put all smaller elements(smaller than x) before x,
    ///and put all greater elements(greater than x) after x.
    ///All this should be done in linear time.


    /// Algorithum for Partiton
    ///1. parameter 
    ///2. arr,low,high
    ///3. pivot=low
    ///4. increment low untill element less than pivot found
    ///5. decrement high untill element greater pivot found
    ///6. swap untill we found greater element on high index
    ///7. if not able to found than right high index.
    ///
    ///
    /// Algorithum QuickSort
    /// parameter
    /// array,low value index,high value index
    /// if low is less than high
    /// partionindex store the value of index of pivot after parttion
    /// call partition 
    /// sort call for left subarray recursively
    /// sort call for right subarray recursively
    /// </summary>
    public class QuickSortAnalysis
    {
        public void QuickSort(int[] arr, int low, int high)
        {
            int partitionIndex;//index of pivot after partition.
            if (low < high)
            {


                partitionIndex = partition(arr, low, high);
                if(partitionIndex > 1)
                {
                    QuickSort(arr, low, partitionIndex - 1);//sort left subarray

                }
                if(partitionIndex+1 < high)
                {
                    QuickSort(arr, partitionIndex + 1, high);//sort right subarray

                }
            }
        }

        private int partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
           
            int temp;


            while (true)
            {



                while (arr[low] < pivot)
                {
                    low++;
                }
                while (arr[high] > pivot)
                {
                    high--;
                }
                if (low < high)
                {
                    if (arr[low] == arr[high])
                    {
                        return high;
                    }

                    temp = arr[high];
                    arr[high] = arr[low];
                    arr[low] = temp;
                }
                else
                {
                    return high;
                }
                
               
                    
                


            }
           
        }


    }
    
}

   


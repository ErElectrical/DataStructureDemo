using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{
    public class InsertionSortAnalysis
    {
        /// <summary>
        /// Insertion sort is a simple sorting algorithm 
        /// that works similar to the way you sort playing cards 
        /// in your hands. 
        /// The array is virtually split into a sorted and an unsorted part. 
        /// Values from the unsorted part are picked and placed at the correct position in the sorted part.
        ///Algorithm 
        ///1: Iterate from arr[1] to arr[n] over the array. 
        ///2: Compare the current element (key) to its predecessor. 
        ///3: If the key element is smaller than its predecessor,
        ///compare it to the elements before.
        ///Move the greater elements one position up to make space for the swapped element.
        /// </summary>
        /// <param name="arr"></param>
        public void InsertionSort(int[] arr)
        {
            //key holds the current element
            //j will take care of precedance element index so that tracking becomes easier
            int key, j;
            for(int i =0;i<=arr.Length-1;i++)//loop for passes
            {
                key= arr[i];
                j = i - 1;
                //loop for reach passes
                while(j>=0 && arr[j] > key)
                {
                    //move the value to precedance position
                    arr[j + 1] = arr[j];
                    
                    j--;
                }
                //move the value to precedence position.
                arr[j + 1] = key;
            }
        }
    }
}

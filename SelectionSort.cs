using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{
    public class SelectionSortAnalysis
    {
        /// <summary>
        /// The selection sort algorithm sorts an array by repeatedly finding the minimum 
        /// (considering ascending order) from unsorted part and putting it at the beginning. 
        /// The algorithm maintains two subarrays in a given array.
        ///1) The subarray which is already sorted.
        ///2) Remaining subarray which is unsorted.
        ///In every iteration of selection sort, the minimum element(considering ascending order) 
        ///from the unsorted subarray is picked and moved to the sorted subarray.

        /// </summary>
        /// <param name="arr"></param>
        public void SelectionSort(int[] arr)
        {
            //varible that will consider the minimum value index
            int indexOfMin,temp;
            Console.WriteLine("Running Selection sort ");
            for(int i=0; i<=arr.Length-1;i++)//for passes
            {
                Console.WriteLine("Working on pass : {0} ", i);
                //no matter what we have at ith index just declare it as indexofmin value
                indexOfMin = i;
                for(int j=i+1;j<=arr.Length-1;j++)
                {
                    //check weather value is greater or not if found greater than replace the indexofmin
                    if(arr[j]<arr[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }
                //swapping occurs here
                temp = arr[i];
                arr[i] = arr[indexOfMin];
                arr[indexOfMin] = temp;
            }
        }
    }
}

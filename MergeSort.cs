using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{
    public class mergeSortAnalysis
    {
        /// <summary>
        /// three varible that will work as a index pointer for each arr
        /// searching untill we  traverse in both array
        /// put data into bigger array from firstarray whenever found greater value on second array index
        /// 
        /// if not found condition than put data into biggerarray from second array
        /// if any of array traverse complete than directly put the data of remaining array into bigger array 
        /// </summary>
        /// <param name="firstarr"></param>
        /// <param name="secondarr"></param>
        /// <param name="arr"></param>
        /// <param name="firstarrlen"></param>
        /// <param name="secondarrlen"></param>
        public void mergesort(int[] firstarr,int[] secondarr,int[] arr,int firstarrlen,int secondarrlen)
        {
            int i=0, j=0, k = 0;
            while(i<=firstarrlen-1 && j<=secondarrlen-1)
            {
                if(firstarr[i]<secondarr[j])
                {
                    arr[k]=firstarr[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k]=secondarr[j];
                    k++;
                    j++;
                }
            }
            while(i<=firstarrlen-1)
            {
                arr[k] = firstarr[i];
                k++;
                i++;
            }
            while(j<=secondarrlen-1)
            {
                arr[k] = secondarr[j];
                k++;
                j++;
            }
        }

        /// <summary>
        /// Merge Master algorithum
        /// when low less than high
        /// recusively call for lefy side subarray
        /// recursively call for right side subarray
        /// call for merge function
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public void MergeMaster(int[] arr,int low,int high)
        {
            int mid;
            if(low < high)
            {
                mid = (low + high) / 2;
                MergeMaster(arr, low, mid);
                MergeMaster(arr, mid + 1, high);
                merge(arr, mid, low, high);

            }
        }

        /// <summary>
        /// same merging algorithum we use in mergesort method
        /// but instaed of putting data from two differnt array we split the
        /// single array into two differnet virtual array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="mid"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private void merge(int[] arr,int mid,int low,int high)
        {
            int i = low, j = mid + 1, k = low;
            int[] clonearr = new int[high + 1];

            while(i<=mid && j<=high)
            {
                if(arr[i]<arr[j])
                {
                    clonearr[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    clonearr[k] = arr[j];
                    k++;
                    j++;
                }
            }
            while(i<=mid)
            {
                clonearr[k] = arr[i];
                k++;
                i++;
            }
            while(j<=high)
            {
                clonearr[k] = arr[j];
                k++;
                j++;
            }

            for(int m=low;m<=high;m++)
            {
                arr[m] = clonearr[m];
            }
        }
    }
}

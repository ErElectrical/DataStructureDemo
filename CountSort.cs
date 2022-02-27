using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{
    public class CountSortAnalysis
    {
        /// <summary>
        /// counting sort is a sorting technique based on keys
        /// between a specific range. 
        /// It works by counting the number of objects having distinct
        /// key values (kind of hashing).
        /// Then doing some arithmetic to calculate the position 
        /// of each object in the output sequence.
        /// 
        /// algorithum for countsort
        /// create a array which size is of gretest element of given array
        /// initilise with zero for newly created array
        /// fill all the indexes with 1 of newly created array which are same as element of given array
        /// feed the given array with newlycreated array where we have 1 at any index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="len"></param>
        public void Countsort(int[] arr,int len)
        {
            int indexarr=0, indexclonearr=0;
            //find the maximum value in arr

            int max = maximum(arr, len);

            //create an array have size one greter than max
            int[] clonearr = new int[max + 1];
            //populate the arr value with 0.
            for(int i =0;i<max+1;i++)
            {
                clonearr[i] = 0;
            }
            //populate clonearr with 1 at indexes that are present as element in our input arr
            for(int j=0;j<len;j++)
            {
                clonearr[arr[j]] = clonearr[arr[j]] + 1 ;

            }

            while(indexclonearr <= max)
            {
                if(clonearr[indexclonearr] > 0)
                {
                    arr[indexarr] = indexclonearr;
                    clonearr[indexclonearr] = clonearr[indexclonearr] - 1;
                    indexarr++;
                }
                else
                {
                    indexclonearr++;
                }
                    
            }


        }

        private static int maximum(int[] arr,int len)
        {
            int max = int.MinValue;
            for(int i = 0;i<len;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            return max;

        }
    }
}

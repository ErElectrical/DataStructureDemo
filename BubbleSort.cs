using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithumAnalysis
{
    public class BubbleSortAnalysis
    {
        public  void ShowArray(int[] arr)
        {
            int i = 0;
            while(i<=arr.Length-1)
            {
                Console.WriteLine("Element : {0} ", arr[i]);
                i++;
            }
            Console.WriteLine("\n");
        }

        public void BubbleSort(int[] arr)
        {
            int temp;
            int issorted = 0;//for adaptiveness of bubble sort Algorithum
            for(int i=0;i<arr.Length-1;i++)//For number of passes
            {
                Console.WriteLine("Working on pass : {0} ", i + 1);
                issorted = 1;
                for(int j=0;j<arr.Length-1-i;j++)//for comparison in passes
                {
                    if(arr[j]>arr[j+1])
                    {
                        //swapping of data through a temporary varible
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        issorted = 0;
                    }
                }
                if(issorted==1)
                {
                    return;
                }
            }
        }
    }
}

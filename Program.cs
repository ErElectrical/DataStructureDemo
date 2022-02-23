using System;

namespace ArraywithAbstarct
{
    public class Program
    {
    
        //create a Array
        private static  int AskSizeOfArray()
        {
            Console.WriteLine("Enter length of Array ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        

        //Traversal meaning visit to each member once
        private static void TraverseArray(int[] arr)
        {
            if(arr.Length > 0)
            {
                Console.WriteLine("Array has following member ");
                foreach(int x in arr)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("Array is Empty ");
            }
        }

        private static void FeedtheArray(int[] arr)
        {
 
            Console.WriteLine("enter a string of integer with comma sepreation ");
            string input = Console.ReadLine();
            int i;
            string[] inputstring = input.Split(',');
            for( i =0;i< arr.Length;i++)
            {
                int num;
                bool validate = int.TryParse(inputstring[i],out num);
                if(validate && inputstring.Length == arr.Length)
                {
                    arr[i] = num;

                }
                else
                {
                    Console.WriteLine("Check something went wrong");
                    break;
                }
               
            }
                
        }

        private static void  DeleteArrayOnSpecificIndex(int[] arr)
        {
            Console.WriteLine("enter index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            if(index < arr.Length)
            {
                Console.WriteLine("Deletion is Possible ");
                //start from specified index till total index places we have in array
                for(int i=index;i <arr.Length-1;i++)
                {
                    //shifting the mamber of array after index.
                    arr[i] = arr[i + 1];
                }
                
            }
            else
            {
                Console.WriteLine("Index out of range ");
            }
        }

        private static void LinearSearch(int[] arr,int element)
        {
            bool flag = false;
            int i;
            for(  i = 0;i<=arr.Length - 1;i++)
            {
                if(arr[i] == element)
                {
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("element not found ");
            }
            else
            {
                Console.WriteLine($"element found at {i} index");
            }
        }

        //Binary Search works on sorted array only.
        private static void BinarySearch(int[] arr,int element)
        {
            //set three ranges of index
            //low at 0 index
            //high at biggest index.
            //mid is median of both high and low
            int low = 0, mid = 0, high  = arr.Length-1;
            bool flag = false;
            while(low <= high)
            {
                mid = (low + high) / 2;
                if(arr[mid] == element)
                {
                    flag = true;
                    break;

                }
                if(arr[mid]<element)
                {
                    low = mid+1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            if(flag == false)
            {
                Console.WriteLine("element not found ");
            }
            else
            {
                Console.WriteLine($"element found at {mid} index");
            }
        }

        static void Main()
        {
            int length = AskSizeOfArray();
            int[] arr = new int[length];
            FeedtheArray(arr);

            // DeleteArrayOnSpecificIndex(arr);

            // TraverseArray(arr);

           // LinearSearch(arr, 5);

            BinarySearch(arr, 5);




        }



    }
}

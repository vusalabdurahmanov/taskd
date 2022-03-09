using System;

namespace array
{
    internal class Program
    {
        #region Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.
        static void Main(string[] args)
        {
            int[] arr = {1,2, 3,4,224,346,-75,234,0};
            Console.Write(min(arr));   
        }
        static int min(int[] arr)
        {
            // Unsorted array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find minumu element in array
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                    // Swap found minimum element to first
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                }
            }
            return arr[0]; //Return first element because sorteder array first element is minumum 
        }



        #endregion
        #region NumLength methodu yaradılır. Daxil olunan ədədin rəqəmləri sayını tapır.
        //static void Main(string[] args)
        //{
        //    var input =Convert.ToInt64(Console.ReadLine());//Convert to long 
        //    Console.WriteLine(NumLength(input));
        //}
        //static long NumLength(long num)
        //{
        //    int count = 0;//Count each step 
        //    if(num ==0) return 1;else
        //    while (num != 0)
        //    {
        //        num = num / 10;
        //        count++;
        //    }
        //    return count;
        //}
        #endregion
        #region  VowelLetter yaradılır. Daxil olunan mətndə neçə sait hərf olduğunu tapsın
        //static void Main(string[] args)
        //{
        //    string name = Console.ReadLine();
        //    Console.WriteLine(VowelLetter(name));
        //}
        //static string VowelLetter(string name)
        //{

        //    bool hasA = false;
        //    int count = 0;
        //    char[] arr = name.ToCharArray();//Change array to char 
        //    foreach (char item in arr)//Check each letter 
        //    {
        //        if (item == 'e' || item == 'u' || item == 'i' || item == 'o' || item == 'a'|| item == 'E' || item == 'U' || item == 'I' || item == 'O' || item == 'A')
        //        {
        //            hasA = true;
        //            count++;
        //        }

        //    }
        //    return Convert.ToString(count);
        //}
        #endregion

    }
}

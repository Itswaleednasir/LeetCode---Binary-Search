using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {-1, 0, 3, 5, 9, 12};
            var target = 5;

            var targetIndex = Search(array, target);

            Console.WriteLine("Target Index: {0}", targetIndex);
        }
        
        public static int Search(int[] nums, int target)
        {
            int startIndex = 0; // Start index of array
            int endIndex = nums.Length - 1; // End index of array
            
            // Iterate until start index is less than or equals to end index
            // because that's how we gonna find our target index
            // When start & end index is reach to the same position
            while(startIndex <= endIndex) 
            {
                // mid point of two point always comes by (start + end) / 2
                int midIndex = (startIndex + endIndex) / 2; 
                
                if (target == nums[midIndex]) // Check if our mid index is reached to our targeted value
                    return midIndex; // return mid index as it's value is equals to our target value
                
                if (target < nums[midIndex])  // Check if target value is less than our mid index value
                    endIndex = midIndex - 1; // shift end index to (mid index - 1) as we already know we don't need right side of array  
                else // Now only the last case is left when our target value is greater than mid index value 
                    startIndex = midIndex + 1; // shift start index to (mid index + 1) as we already know we don't need left side of array
            }
            return -1; // return -1 when our target is not found
        }
    }
}
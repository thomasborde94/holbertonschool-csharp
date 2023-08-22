using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Defines the Operations Class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns max int of a list of ints
        /// </summary>
        /// <param name="nums">List to find highest int</param>
        /// <returns>Max integer in list, or 0 if nums is empty</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            
            int highest = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                    highest = nums[i];
            }
            return highest;
        }
    }
}

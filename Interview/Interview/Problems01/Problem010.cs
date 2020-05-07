using System;
using System.Collections.Generic;

namespace Interview.Problems01
{
    /// <summary>
    ///     在排序数组中查找和为给定值的两个数字
    /// </summary>
    public class Problem010
    {
        public static bool Solve(List<int> sortedNumbers, int target, out int a, out int b)
        {
            if (sortedNumbers == null)
                throw new ArgumentNullException(nameof(sortedNumbers));

            int start = 0;
            int end = sortedNumbers.Count - 1;

            while (start < end)
            {
                int sum = sortedNumbers[start] + sortedNumbers[end];
                if (sum == target)
                {
                    a = sortedNumbers[start];
                    b = sortedNumbers[end];
                    return true;
                }
                if (sum > target)
                    end--;
                else
                    start++;
            }

            a = 0;
            b = 0;
            return false;
        }
    }
}
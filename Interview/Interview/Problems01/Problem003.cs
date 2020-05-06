using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems01
{
    /// <summary>
    ///     求子数组的最大和
    /// </summary>
    public class Problem003
    {
        // 原题的解说:
        // 很容易理解，当我们加上一个正数时，和会增加；当我们加上一个负数时，和会减少。如果当前得到的和
        // 是个负数，那么这个和在接下来的累加中应该抛弃并重新清零，不然的话这个负数将会减少接下来的和。
        //
        // 但我个人觉得这道题目的解并不那么的直观, 解释如下
        // 想象一下为了找到最大子数组, 那么用两个指针p和q分别指向这个子数组的开始和结束
        // 一开始p = q = 0, 计算Sum(p, q), q++, 记录其中的最大值
        // 当Sum(p, q) < 0, 就要让p, q全部指向q+1, 因为不存在另外一个点p' (p < p' <= q), 可以使得Sum(p', q) > 0
        // 假设存在该点p'使得Sum(p', q) > 0, 那么必然有Sum(p, p' - 1) < 0, 但根据算法, 此时已经清零, 矛盾

        public static int BetterSolve(List<int> numbers)
        {
            if(numbers == null || numbers.Count == 0)
                throw new ArgumentException("Invalid argument", nameof(numbers));

            int maxSum = 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
                if (sum < 0)
                    sum = 0;
                else if (maxSum < sum)
                    maxSum = sum;
            }

            return maxSum == 0 ? numbers.Max() : maxSum;
        }

        public static int Solve(List<int> list)
        {
            // 如果全部是负数, 那么找出绝对值最小的负数即为解
            // 将连续的同符号数相加, 得到的结果保存到一个新的列表中, 并且去除前后的负数部分
            // 此时列表的排列必然是正, 负, ..., 负, 正
            // 对一个列表求靠左的最大子数组, 和非靠左的最大子数组
            // 如果列表只有一个元素, 那么左即为该数, 右为0
            // 如果列表有多个元素, 那么取第一个数为P1, 第二个数为N1, P1是正数, N1为负数
            // 对剩余部分递归求左侧最大, 和非左侧最大, 分别记为L和R
            // 那么对于当前的列表有:
            // 如果P1 + N1 > 0 或 L + N1 > 0, 左 = P1 + N1 + L, 右 = R;
            // 否则, 左 = P1, 右 = max(L, R)

            int maxNegativeNumber = int.MinValue;
            var newList = new List<int>();

            // 这里假设没有0
            int sum = 0;
            foreach (int i in list)
            {
                if (i < 0)
                    if (maxNegativeNumber < i)
                        maxNegativeNumber = i;

                if (sum != 0)
                {
                    if (Math.Sign(i) == Math.Sign(sum))
                    {
                        sum += i;
                    }
                    else
                    {
                        if (newList.Count > 0 || sum > 0)
                            newList.Add(sum);
                        sum = i;
                    }
                }
                else
                {
                    sum = i;
                }
            }

            if (sum > 0)
                newList.Add(sum);

            if (newList.Count == 0)
                return maxNegativeNumber;

            Solve(newList, 0, out int left, out int right);
            int max = Math.Max(left, right);
            return max;
        }

        private static void Solve(List<int> list, int startIndex, out int left, out int right)
        {
            if (startIndex >= list.Count)
            {
                left = 0;
                right = 0;
                return;
            }

            if (startIndex == list.Count - 1)
            {
                left = list[startIndex];
                right = 0;
                return;
            }

            int p1 = list[startIndex];
            int n1 = list[startIndex + 1];
            Solve(list, startIndex + 2, out int leftOfRest, out int rightOfRest);

            if (p1 + n1 > 0 && n1 + leftOfRest > 0)
            {
                // 左侧合并
                left = p1 + n1 + leftOfRest;
                right = rightOfRest;
            }
            else
            {
                // 分离, 看左右谁大
                left = p1;
                right = Math.Max(leftOfRest, rightOfRest);
            }
        }
    }
}

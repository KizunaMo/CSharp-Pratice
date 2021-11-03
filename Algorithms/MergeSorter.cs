using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class MergeSorter
    {
        public static void DoMergeSort(this int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers;//base case;

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }


        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveValueFromSourseToResult(left, result);
                else
                    MoveValueFromSourseToResult(right, result);
            }

            while (NotEmpty(left))
            {
                MoveValueFromSourseToResult(left, result);
            }
            while (NotEmpty(right))
            {
                MoveValueFromSourseToResult(right, result);
            }

            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourseToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}

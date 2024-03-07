using System;
using System.Collections.Generic;

class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            numIndices[nums[i]] = i;
        }

        throw new ArgumentException("No two number found.");
    }

    static void Main()
    {
        Console.WriteLine("INPUT (comma separated):");
        string[] inputArray = Console.ReadLine().Split(',');

        int[] nums = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            nums[i] = Convert.ToInt32(inputArray[i]);
        }

        Console.WriteLine("TARGET:");

        int target = Convert.ToInt32(Console.ReadLine());

        TwoSumSolution solution = new TwoSumSolution();

        try
        {
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"OUTPUT: [{result[0]}, {result[1]}]");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

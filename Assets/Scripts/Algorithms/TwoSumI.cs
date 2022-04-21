using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSumI : MonoBehaviour
{

    //MY WAY
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        if (nums.Length == 2)
        {
            result[0] = 0;
            result[1] = 1;
            return result;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int save = target - nums[i];

            int index = Array.IndexOf(nums, save);
            if (index != -1 && index != i)
            {
                result[0] = i;
                result[1] = index;
                return result;
            }
        }

        return result;
    }

    //A BETTER WAY
    // public int[] TwoSum(int[] nums, int target)
    // {
    //     var dict = new Dictionary<int, int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         var diff = target - nums[i];
    //         if (dict.ContainsKey(diff))
    //         {
    //             return new int[] {dict[diff], i};
    //         }
    //         else
    //         {
    //             dict.TryAdd(nums[i], i);
    //         }
    //     }
    //
    //     return new int[] { };
    // }
}
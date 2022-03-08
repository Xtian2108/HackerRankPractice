using System;
using UnityEngine;

namespace Assets.Scripts._2D_Array___DS
{
    public class SortedSquaresTest : MonoBehaviour
    {
        /// <summary>
        /// LINK https://leetcode.com/problems/squares-of-a-sorted-array/
        /// </summary>
        private int[] result;
        private int[] nums;
        private void Start()
        {
            result = SortedSquares(nums);
        }

        
        
        /// MY WAY
        public int[] SortedSquares(int[] nums) 
        {
            int[] result = new int[nums.Length];
                
            for(int i=0; i<nums.Length; i++)
            {
                double pow = Math.Pow(Math.Abs(nums[i]),2);
                result[i] = Convert.ToInt32(pow);
            }
        
            Array.Sort(result);

            return result;
        }
        
        ///BETTER WAY - LESS EXPENSIVE
        
        // public int[] SortedSquares(int[] nums) {
        //     int[] results = new int[nums.Length];
        //     for(int i=0;i< nums.Length; i++)
        //     {
        //         results[i] = nums[i] * nums[i];
        //     }
        //
        //     Array.Sort(results);
        //     return results;
        // }

    }
}
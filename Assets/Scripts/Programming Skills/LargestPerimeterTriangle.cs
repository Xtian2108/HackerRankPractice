using System;
using UnityEngine;

namespace Assets.Scripts.Programming_Skills
{
    public class LargestPerimeterTriangle : MonoBehaviour
    {
        //https://leetcode.com/problems/largest-perimeter-triangle/
        public int LargestPerimeter(int[] nums) 
        {
            Array.Sort(nums);
            for(int i=nums.Length-1;i>=2;i--)
            {
                //Triangle Inequality
                if(nums[i] < nums[i-1] + nums[i-2])
                {
                    return nums[i] + nums[i-1] + nums[i-2];
                }
            }
            return 0;
        }
    }
}
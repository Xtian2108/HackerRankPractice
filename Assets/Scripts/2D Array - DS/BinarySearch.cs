using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    public int[] listOfNumber;
    public int target;
    public int result;
    
    /// <summary>
    /// LINK: https://prnt.sc/Pj3chEKY1F1T
    /// LINK: https://leetcode.com/problems/binary-search/
    /// </summary>
    private void Start()
    {
        result = Search(listOfNumber,target);
    }

    public int Search(int[] nums, int target) 
    {
        if(nums.Length == 0) return -1;
        
        int left = 0;
        int right = nums.Length-1;
        
        while(left <= right)
        {
            int midpoint = left +(right-left) /2;
            if(nums[midpoint] == target)
            {
                return midpoint;
            }else if (nums[midpoint] > target){
                right = midpoint -1;
            }else{
                left = midpoint +1;
            }
        }
        return -1;
    }
    
    
    /// THE EASY WAY BUT IT'S NOT OPTIMAL
   
    // public int Search(int[] nums, int target) 
    // {
    //     int index = 0;
    //   
    //     index = Array.IndexOf(nums, target);
    //     return index;
    // }
}

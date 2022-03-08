using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchInsertPosition : MonoBehaviour
{

    // LINK: https://prnt.sc/rNTFSYDpJyKy
    // LINK: https://leetcode.com/problems/search-insert-position/
    public int[] listOfNumber;
    public int target;
    public int result;
    
    private void Start()
    {
        result = SearchInsert(listOfNumber,target);
    }
    
    public int SearchInsert(int[] nums, int target) 
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
        return left;
    
    }
}

using UnityEngine;

namespace Assets.Scripts._2D_Array___DS
{
    public class RotateArrayTest : MonoBehaviour
    {
        
        //https://leetcode.com/problems/rotate-array/
        //MY WAY
        public void Rotate(int[] nums, int k) 
        {
            int[] output = new int[nums.Length];
            int length = nums.Length;
            for(int i=0; i<nums.Length; i++) {
                output[(i+k) % length] = nums[i];
            }
            for(int i=0; i<nums.Length; i++) {
                nums[i] = output[i];
            }
        }
        
        //FAST WAY
        
        // public void Rotate(int[] nums, int k) {
        //     int count = nums.Length;
        //     int fromBack = k % count;
        //     int fromStart = count - fromBack;
        //
        //     reverse(nums, 0, count - 1);
        //     reverse(nums, 0, fromBack - 1);
        //     reverse(nums, fromBack, count - 1);
        // }
        //
        // void reverse(int[] nums, int i, int j) {
        //     while (i < j) {
        //         int temp = nums[i];
        //         nums[i] = nums[j];
        //         nums[j] = temp;
        //         i++;
        //         j--;
        //     }
        // }
        
        
        //ANOTHER WAY
        
        // public void Rotate(int[] nums, int k) {
        //     if(nums.Length<k) k=k%nums.Length;
        //     int[] ans = new int[nums.Length];
        //     Array.Reverse(nums);
        //     Array.Reverse(nums,0,k);
        //     Array.Reverse(nums,k, nums.Length-k);
        // }
        
        
    }
}
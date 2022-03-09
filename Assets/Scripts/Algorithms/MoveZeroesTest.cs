using UnityEngine;

namespace Assets.Scripts._2D_Array___DS
{
    public class MoveZeroesTest : MonoBehaviour
    {
        /// MY WAY
        /// https://leetcode.com/problems/move-zeroes/ 
        /// 

        public void MoveZeroes(int[] nums) 
        {
            int[] result = new int[nums.Length];
            int indice = 0;
        
            for(int i=0; i<nums.Length;i++)
            {
                if(nums[i] != 0)
                {
                    result[indice] = nums[i];
                    indice++;
                }   
            }
        
            for(int i=0; i<nums.Length;i++)
            {
                nums[i] = result[i];
            }
        }
        
        
        ///FASTEST WAY
        
        // public void MoveZeroes(int[] nums) {
        //     int lastNonZeroIndex = 0 ;
        //
        //     for(int i = 0; i < nums.Length; i++) {
        //         if(nums[i] != 0)
        //         {
        //             int temp = nums[lastNonZeroIndex];
        //             nums[lastNonZeroIndex] = nums[i];
        //             nums[i] = temp;
        //             lastNonZeroIndex++;
        //         }
        //     }
        // }
    }
}
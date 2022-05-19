using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts._2D_Array___DS
{
    public class TwoSumII : MonoBehaviour
    {
        //Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        /// <summary>
        /// MY WAY THAT ITS SLOWER FOR BIG AMOUNT OF NUMBERS
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        
        public int[] TwoSum(int[] numbers, int target) 
        {
            List<int> result = new List<int>();
            int inc = 0;
            bool isOver = false;
            if(numbers.Length == 2)
            {
                result.Add(1);
                result.Add(2);
                return result.ToArray();
            }
        
            do{
                for(int i=0;i<numbers.Length;)
                {
                    if(inc != i)
                    {
                        if(numbers[inc] + numbers[i] == target)
                        {
                            result.Add(inc+1);
                            result.Add(i+1);
                            isOver = true;    
                        }
                    }
                    i++;
                }
                inc++;
            
                if(inc >= numbers.Length)
                {
                    isOver = true;    
                }
            
            }while(!isOver);
            
        
            return result.ToArray();
        }
        
        
        
        /// THE GOOD WAY USING BINARY SEARCH
        
        // public int[] TwoSum(int[] numbers, int target) 
        // {
        //     int a_pointer = 0;
        //     int b_pointer = numbers.Length-1;
        //
        //     while(a_pointer <= b_pointer)
        //     {
        //         int sum = numbers[a_pointer] + numbers[b_pointer];
        //     
        //         if(sum > target) 
        //         {
        //             b_pointer -=1;
        //         }
        //         else if(sum <target)
        //         {
        //             a_pointer +=1;
        //         }else{
        //             return new int[] {a_pointer+1,b_pointer+1};
        //         }
        //     }
        //
        //     return new int[] {a_pointer+1, b_pointer+1};
        // }
        
        
        // THE FASTEST WAY
        
        
        // public int[] TwoSum(int[] numbers, int target) {
        //     int left = 0, right = numbers.Length - 1;
        //     while (true)
        //     {
        //         int current = numbers[left] + numbers[right];
        //         if (current > target) right--;
        //         else if (current < target) left++;
        //         else return new int[]{ left + 1, right + 1 };   
        //     }       
        //     return null;
        // }
    }
}
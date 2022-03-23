using UnityEngine;

namespace Assets.Scripts.Programming_Skills
{
    public class SubstractProductAndSum : MonoBehaviour
    {
        //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
        public int SubtractProductAndSum(int n) 
        {
            int sum = 0, multi = 1;
        
            while(n != 0)
            {
                int num = n % 10;
                n = n / 10;
                sum += num;
                multi *= num;
            }
    
            return multi - sum;   
        }
    }
}
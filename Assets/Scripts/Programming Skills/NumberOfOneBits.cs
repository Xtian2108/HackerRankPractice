using UnityEngine;

namespace Assets.Scripts.Programming_Skills
{
    public class NumberOfOneBits : MonoBehaviour
    {

        public void Start()
        {
            HammingWeight(0);
        }
        
        //https://leetcode.com/problems/number-of-1-bits/
        public int HammingWeight(uint n) 
        {
            var count = 0;
            while(n != 0)
            {
                if((n & 1) == 1)
                    count++;
                n = n >> 1;
            }
            return count;
        }
    }
}
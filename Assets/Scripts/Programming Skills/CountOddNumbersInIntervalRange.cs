using UnityEngine;

namespace Assets.Scripts.Programming_Skills
{
    public class CountOddNumbersInIntervalRange : MonoBehaviour
    {
        /// <summary>
        /// MY SOLUTION
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int CountOdds(int low, int high) 
        {
            int odds = 0;
            for(int i=low; i <=high;i++)
            {
                if(i%2!=0){
                    odds++;
                }    
            }    
        
            return odds;
        }
        
        
        // BEST SOLUTION
        
        // public int CountOdds(int low, int high) {
        //     int lowCount=low/2;
        //     int highCount=(high+1)/2;
        //     return highCount-lowCount;
        //
        // }
        
    }
}
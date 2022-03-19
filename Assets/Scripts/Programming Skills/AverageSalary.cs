using System;
using UnityEngine;

namespace Assets.Scripts.Programming_Skills
{
    public class AverageSalary : MonoBehaviour
    {
        
        /// <summary>
        /// MY WAY
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public double Average(int[] salary) 
        {

            double sum = 0;
            Array.Sort(salary);
            for(int i = 1; i < salary.Length -1; i++)
            {
                sum+=salary[i];
            }
                
            return (double)(sum / (salary.Length - 2)); 
        }
    }
}
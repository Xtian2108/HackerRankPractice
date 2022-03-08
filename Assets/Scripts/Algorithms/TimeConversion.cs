using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeConversion : MonoBehaviour
{
    // LINK OF PROBLEM: https://prnt.sc/3w84IbrEqePd
    // LINK OF PROBLEM: https://www.hackerrank.com/challenges/time-conversion/


    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public string result;

    private void Start()
    {
        result = timeConversion("07:05:45PM");
        // timeConversion("12:40:22AM");
    }


    public static string timeConversion(string s)
    {
        char[] charList = s.ToCharArray();

        int hour = int.Parse($"{charList[0]}{charList[1]}");
        int minute = int.Parse($"{charList[3]}{charList[4]}");
        int second = int.Parse($"{charList[6]}{charList[7]}");

        string AMPM = $"{charList[charList.Length - 2]}{charList[charList.Length - 1]}";

        if (AMPM == "PM")
        {
            if (hour != 12)
            {
                hour += 12;
            }
        }
        else
        {
            if (hour >= 12)
            {
                hour -= 12;
            }
        }

        string result = string.Empty;
        result = $"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}";


        return result;

        

         /*
         
         bool successfulconversion = DateTime.TryParse(s, out DateTime time);
         if (successfulconversion)
         {
            return time.ToString("HH:mm:ss");
         }
         return "HackerRank gave me bad input";
         
         */
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    public int n;

    public string r;

    // Start is called before the first frame update
    
    // CHALLENGE
    // https://prnt.sc/B7HSujrPY88b
    void Start()
    {
        List<string> separate = r.Split().ToList();
        int value1 = Int32.Parse(separate[0]);
        int value2 = Int32.Parse(separate[2]);
        int result = value1;

        do
        {
            result += n;
            if (result <= value2)
            {
                Debug.Log(result);
            }
        } while (result <= value2);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASCIIART : MonoBehaviour
{
    private int L = 4;
    private int H = 5;
    public string T;
    public string row;
    public string ret = "";
    void Start()
    {
        const int A = (int)'A';
        const int Z = (int)'Z';

        string str = T.ToUpper();

        for (int i = 0; i < H; i++)
        {
            foreach (var s in str)
            {
                var c = (int)s;

                if (c < A || c > Z)
                    ret += row.Substring(L * (Z - A + 1), L);
                else
                    ret += row.Substring(L * (c - A), L);
            }

            // Console.WriteLine(ret);
            Debug.Log(ret);
        }
    }
}
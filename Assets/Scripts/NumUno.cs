﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumUno : MonoBehaviour
{
    int num1 = 0;
    int multi = 0;
    // Start is called before the first frame update
    void Start()
    {
        num1 += 2;
        Debug.Log(num1);
        multi = num1 * num1;
        Debug.Log(multi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

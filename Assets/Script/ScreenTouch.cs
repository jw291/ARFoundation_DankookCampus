﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTouch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("화면 터치!");
        }
    }
}

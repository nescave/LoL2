using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grid : MonoBehaviour
{
    public float GridWidth;
    public float GridHeight;
    public int GridFieldsA;
    public int GridFieldsB;

    void Start()
    {
        GridWidth = 1.0f;
        GridHeight = GridWidth * (float)Math.Tan(Math.PI * 2/3) * 0.5f; //Move to Start() 16
        GridFieldsA = 10;
        GridFieldsB = 5;

        
    }

    void Update()
    {
        
    }
}
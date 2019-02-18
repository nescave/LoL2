using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grid : MonoBehaviour
{
    public float GridWidth;
    float GridHeight;
    public int GridFieldsA = 10;
    public int GridFieldsB = 5;
    public Transform hex;

    void Start()
    {
        GridHeight = GridWidth * (float)Math.Tan(Math.PI * 2/3) * 0.5f;
        for (int i = 0; i < GridFieldsA; i++){
            for (int j = 0; j < GridFieldsB; j++){
                
                if (j%2 == 0){
                    Instantiate(hex, new Vector3(i * GridWidth, 0, j * GridHeight), Quaternion.identity);
                }
                else{
                    Instantiate(hex, new Vector3((i + 0.5f) * GridWidth, 0, j * GridHeight), Quaternion.identity);
                }

            }
        }
    }

    void Update()
    {
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Calculator : MonoBehaviour
{
    int[] numbers = {28,  47, 128, 
                    129, 106, 173,
                    233, 228, 212,
                    102,   0,   0,
                      0, 133, 132,
                      0, 148, 201,
                    245, 223, 160,
                    109, 123, 141,
                     86,  80,  81,
                     52,  40,  44,
                    243, 229, 171};                   
    float[] numbersF = {0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,
                        0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,
                        0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f};

    float x = 0f;
    int i = 0;
  
    int j = 0;
    int numba = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        Calculate();
    }
    // Update is called once per frame
    void Update()
    {
     
    }   

    void Calculate()
    {
        foreach (int number in numbers)
        {
            /*
                255 = 1f
                number = x
                */               
            x = (float)number * 1f / 255f;

            numbersF[i] = x;
            i++;        
        }

        while (numba <= 10)
        {
            Debug.Log("#"+numba+" : "+numbersF[j]+", "+numbersF[j+1]+", "+numbersF[j+2]);

            numba++; 
            j =+ 3;
        }  
    }    
}
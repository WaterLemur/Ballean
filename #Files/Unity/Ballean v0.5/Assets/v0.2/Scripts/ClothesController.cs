using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesController : MonoBehaviour
{
    SpriteRenderer hat, tie, sr;
    GameObject go1, go2;
    byte counter = new byte();

    public byte random = new byte();

    void Start()
    {
        hat = gameObject.transform.Find("Hat").GetComponent<SpriteRenderer>();
        tie = gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>();
        // Debug    ////////////////////////////////////////////////////////////////////////////////
        if (hat == gameObject.transform.Find("Hat").GetComponent<SpriteRenderer>()) 
        {
            Debug.Log("Hat : ✓");
        }
        else
        {
            Debug.Log("Hat : ✘");
        }
        if (tie == gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>())
        {
            Debug.Log("Tie : ✓");
        }
        else
        {
            Debug.Log("Tie : ✘");
        }
        Debug.Log("counter: " +counter);
        // Borrar
        //tie == gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>() ?  Debug.Log("Good") :  Debug.Log("Bad");

        sr = hat;

        while (counter < 2)
        {
            random = (byte)Random.Range(0,11); 

            if (random == 0)
                sr.color = new Color(28, 47, 128, 255);    // Midnight Sky

            else if (random == 1)
                sr.color = new Color(129, 106, 173, 255);  // Lavender

            else if (random == 2)
                sr.color = new Color(233, 228, 212, 255);  // #ede9e4

            else if (random == 3)
                sr.color = new Color(102, 0, 0, 255);      // Fire Brick

            else if (random == 4)
                sr.color = new Color(0, 133, 132, 255);    // Turquoise

            else if (random == 5)
                sr.color = new Color(0, 148, 201, 255); // Blue 

            else if (random == 6)
                sr.color = new Color(245, 223, 160, 255);  // Cream

            else if (random == 7)
                sr.color = new Color(109, 123, 141, 255);  // Rat  

            else if (random == 8)
                sr.color = new Color(86, 80, 81, 255);     // Vampire Grey

            else if (random == 9)
                sr.color = new Color(52, 40, 44, 255);     // Charcoal  

            else if (random == 10)
                sr.color = new Color(243, 229, 171, 255);  // Vanilla   

            sr.color = sr.color / 255;

            Debug.Log("Random #" + (counter + 1) + ": " + random);
            Debug.Log("Clothes are: " + sr.name + " --- color is " + sr.color.ToString());
            sr = tie;
            counter++;
            Debug.Log("counter is now: " + counter);
        }

/*

        do
        {
            random = (byte)Random.Range(0,11); 

            if (random == 0)
                sr.color = new Color(28, 47, 128, 255);    // Midnight Sky

            else if (random == 1)
                sr.color = new Color(129, 106, 173, 255);  // Lavender

            else if (random == 2)
                sr.color = new Color(233, 228, 212, 255);  // #ede9e4

            else if (random == 3)
                sr.color = new Color(102, 0, 0, 255);      // Fire Brick

            else if (random == 4)
                sr.color = new Color(0, 133, 132, 255);    // Turquoise

            else if (random == 5)
                sr.color = new Color(0, 148, 201, 255); // Blue 

            else if (random == 6)
                sr.color = new Color(245, 223, 160, 255);  // Cream

            else if (random == 7)
                sr.color = new Color(109, 123, 141, 255);  // Rat  

            else if (random == 8)
                sr.color = new Color(86, 80, 81, 255);     // Vampire Grey

            else if (random == 9)
                sr.color = new Color(52, 40, 44, 255);     // Charcoal  

            else if (random == 10)
                sr.color = new Color(243, 229, 171, 255);  // Vanilla   


            Debug.Log("Random #" + (counter + 1) + ": " + random);
            Debug.Log("Clothes are: " + sr.name + " color " + sr.color.ToString());
            sr = tie;
            counter++;
            Debug.Log("counter is now: " + counter);
        }
        while (counter < 2);
*/
    }
}

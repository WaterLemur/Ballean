using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    public SpriteRenderer juego, empresa;
    byte[] rgb = { 255, 0, 0 };
    static public int timer = 255;
    static int rgbController = timer;    
    int centinela = 1;

    // Start is called before the first frame update
    void Start()
    {
        juego.color = new Color32(255, 255, 225, 100);
        empresa.color = new Color32(255, 255, 225, 100);
    }
    // Update is called once per frame
    void Update()
    {
        if (centinela == 1)//           1. b = 0->255
        {
            if (rgbController > 0)
            {
                rgb[2] += 1;
                rgbController--;
                ConsoleText.Print("", "blue", "COLOR:  blue", 20);
            }
            else
            {
                centinela++;
                rgbController = timer;
            }
        }
        if (centinela == 2)//           2. r = 255->0
        {
            if (rgbController > 0)
            {
                rgb[0] -= 1;
                rgbController--;
                ConsoleText.Print("", "red", "COLOR:  red", 20);
            }
            else
            {
                centinela++;
                rgbController = timer;
            }
        }
        if (centinela == 3)//           3. g = 0->255
        {
            if (rgbController > 0)
            {
                rgb[1] += 1;
                rgbController--;
                ConsoleText.Print("", "green", "COLOR:  green", 20);
            }
            else
            {
                centinela++;
                rgbController = timer;
            }
        }
        if (centinela == 4)
        {
            if (rgbController > 0)//    4. b = 255->0
            {
                rgb[2] -= 1;
                rgbController--;
                ConsoleText.Print("", "blue", "COLOR:  blue", 20);
            }
            else
            {
                centinela++;
                rgbController = timer;
            }
        }
        if (centinela == 5)
        {
            if (rgbController > 0)//    5. r = 0->255
            {
                rgb[0] += 1;
                rgbController--;
                ConsoleText.Print("", "red", "COLOR:  red", 20);
            }
            else
            {
                centinela++;
                rgbController = timer;
            }
        }
        if (centinela == 6)
        {
            if (rgbController > 0)//    6. g = 255->0
            {
                rgb[1] -= 1;
                rgbController--;
                ConsoleText.Print("", "green", "COLOR:  green", 20);
            }
            else
            {
                centinela = 1;
                rgbController = timer;
            }
        }
        juego.color = new Vector4(rgb[0] / 255f, rgb[1] / 255f, rgb[2] / 255f, 1f);
        empresa.color = new Vector4(rgb[0] / 255f, rgb[1] / 255f, rgb[2] / 255f, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesController : MonoBehaviour
{// Variables
    public SpriteRenderer[] sprite = new SpriteRenderer[3];// hat, bow, tie,
    public GameObject goHat, goBow;
    public SpriteRenderer hat, bow, tie, sr, ezMultiEthnic;
    public byte[,] skinColors = new byte[6, 3] { { 212, 160, 72 }, 
        { 189, 81, 19 }, 
        { 162, 22, 0 },//   { 89, 12, 0 };
        { 255, 189 , 229 }, 
        { 215, 255, 182 },
        { 135, 184, 229} };
    public bool girl = new bool();
    GameObject go1, go2;
    byte random = new byte();
    byte[] color = new byte[3];
    string clotheName = "";


    public Image imgArmadillo, imgHat, imgTie, imgBow, img;
    //
    void Start()
    {// Debug Test ////////////////////////////////////////////////
        ConsoleText.Print("", "magenta", "TEST TEST ", 40);
        ConsoleText.Print("", "magenta", "TEST TEST ", 20);
        ConsoleText.Print("", "magenta", "TEST TEST ", 10);
        /////////////////////////////////////////
        girl = true;
        // Debug Test ////////////////////////////////////////////////
        string titleConsole = "           <b>B</b><i>allean</i>";
        titleConsole = string.Format("<size={0}>{1}</size>", 35, titleConsole);
        Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 255, 255, 0, titleConsole));
        SkinColor();
        // Seleccion de ropa
        if (girl)
        {
            sprite[1] = gameObject.transform.Find("Bow").GetComponent<SpriteRenderer>();
            //bow = gameObject.transform.Find("Bow").GetComponent<SpriteRenderer>();
            //sprite[0].SetActive(false);
            goHat.SetActive(false);
        }
        else
        {
            sprite[0] = gameObject.transform.Find("Hat").GetComponent<SpriteRenderer>();
            //hat = gameObject.transform.Find("Hat").GetComponent<SpriteRenderer>();
            //sprite[2].SetActive(false);
            goBow.SetActive(false);
        }
        sprite[2] = gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>();
        //tie = gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>();
        // Debug
        if (girl)
        {
            if (sprite[1] == gameObject.transform.Find("Bow").GetComponent<SpriteRenderer>())
            {
                ConsoleText.Print("", "cyan", "Bow : ✓", 0);
            }
            else
            {
                ConsoleText.Print("", "red", "Bow : ✘", 0);
            }
        }
        else
        {
            if (sprite[0] == gameObject.transform.Find("Hat").GetComponent<SpriteRenderer>())
            {
                ConsoleText.Print("", "cyan", "Hat :  ✓", 0);
            }
            else
            {
                ConsoleText.Print("", "red", "Hat :  ✘", 0);
            }
        }
        if (sprite[2] == gameObject.transform.Find("Tie").GetComponent<SpriteRenderer>())
        {
            ConsoleText.Print("", "cyan", "Tie :   ✓", 0);
        }
        else
        {
            ConsoleText.Print("", "red", "Tie :   ✘", 0);
        }
        // Bucle color de ropa
        ConsoleText.Print("b", "yellow", "                 CLOTHES:         -         COLOR:", 14);
        for (int i = 0; i < 3; i++)
        {
            ConsoleText.Print("", "green", "                  - counter: " + i, 0);
            random = (byte)Random.Range(0, 11);
            if (random == 0)    // Midnight Sky  
            {
                color[0] = 25;
                color[1] = 47;
                color[2] = 128;
            }
            else if (random == 1)  // Lavender
            {
                color[0] = 129;
                color[1] = 106;
                color[2] = 173;
            }
            else if (random == 2)  // #ede9e4
            {
                color[0] = 233;
                color[1] = 228;
                color[2] = 212;
            }
            else if (random == 3)      // Fire Brick
            {
                color[0] = 233;
                color[1] = 228;
                color[2] = 212;
            }
            else if (random == 4)    // Turquoise
            {
                color[0] = 0;
                color[1] = 133;
                color[2] = 132;
            }
            else if (random == 5) // Blue 
            {
                color[0] = 0;
                color[1] = 148;
                color[2] = 201;
            }
            else if (random == 6)  // Cream
            {
                color[0] = 245;
                color[1] = 223;
                color[2] = 160;
            }
            else if (random == 7)  // Rat  
            {
                color[0] = 109;
                color[1] = 123;
                color[2] = 141;
            }
            else if (random == 8)     // Vampire Grey
            {
                color[0] = 86;
                color[1] = 80;
                color[2] = 81;
            }
            else if (random == 9)     // Charcoal 
            {
                color[0] = 52;
                color[1] = 40;
                color[2] = 44;
            }
            else if (random == 10)  // Vanilla  
            {
                color[0] = 243;
                color[1] = 229;
                color[2] = 171;
            }    
            else//                   debug magenta
            {
                color[0] = 255;
                color[1] = 0;
                color[2] = 255;
            }
            if (i == 0)
            {
                clotheName = "Hat";
                hat.color = new Color(color[0], color[0], color[0]);
                sr = hat;
                img = imgHat;
            }
            else if (i == 1)
            {
                clotheName = "Tie";
                tie.color = new Color(color[0], color[1], color[2]);
                sr = tie;
                img = imgTie;
            }
            else if (i == 2)
            {
                clotheName = "Bow";
                bow.color = new Color(color[0], color[1], color[2]);
                sr = bow;
                img = imgBow;
            }
            sr.color = new Color(color[0]/255f, color[1] / 255f, color[2] / 255f, 1f);
            img.GetComponent<Image>().color = new Color32(color[0], color[1], color[2], 255);
            //img.SourceImage.color = new Color(color[0] / 255f, color[1] / 255f, color[2] / 255f, 1f);
            // [RGB] string
            string tmpStringR = string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 250, 0, 0, "R=" + color[0]);
            string tmpStringG = string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 0, 255, 0, "R=" + color[1]);
            string tmpStringB = string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 0, 0, 255, "R=" + color[2]);
            string shortStr = "";
            if (clotheName == "Bow")
            {
                shortStr = "                               " + clotheName + "          ";
            }
            else
            {
                shortStr = "                                 " + clotheName + "          ";
            }
            string tmpClothes = string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 0, 255, 255, shortStr);
            string strRGB = tmpClothes + "-         [" + tmpStringR + ", " + tmpStringG + ", " + tmpStringB + "]";
            Debug.Log(strRGB);
        }
    }
    void SkinColor()
    {
        random = (byte)Random.Range(0, 256);
        if (random < 170)
        {
            random = (byte)Random.Range(0, skinColors.GetLength(0) / 2);
            if (random == 0)
            {
                ezMultiEthnic.color = new Color32(skinColors[0, 0], skinColors[0, 1], skinColors[0, 2], 255);
            }
            else if (random == 1)
            {
                ezMultiEthnic.color = new Color32(skinColors[1, 0], skinColors[1, 1], skinColors[1, 2], 255);
            }
            else if (random == 2)
            {
                ezMultiEthnic.color = new Color32(skinColors[2, 0], skinColors[2, 1], skinColors[2, 2], 255);
            }
        }
        else
        {
            random = (byte)Random.Range(0, skinColors.GetLength(0) / 2);
            if (random == 0)
            {
                ezMultiEthnic.color = new Color32(skinColors[3, 0], skinColors[3, 1], skinColors[3, 2], 255);
            }
            else if (random == 1)
            {
                ezMultiEthnic.color = new Color32(skinColors[4, 0], skinColors[4, 1], skinColors[4, 2], 255);
            }
            else if (random == 2)
            {
                ezMultiEthnic.color = new Color32(skinColors[5, 0], skinColors[5, 1], skinColors[5, 2], 255);
            }
        }
    }
}

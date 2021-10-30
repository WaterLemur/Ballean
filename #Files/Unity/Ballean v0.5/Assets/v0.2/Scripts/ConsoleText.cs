using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleText : MonoBehaviour
{
    public static byte[] rgb = new byte[3];
    string[] debugString = new string[3];
    static string[] colStrings = { "red" , "green" , "blue", "yellow", "cyan", "magenta", "orange" };
    static bool colBool = false;

    public static void Print(string bi, string color, string txt, int size)
    {
        if (bi != "")
        {
            if (bi.Contains("b") || bi.Contains("i"))
            {
                if (bi.Contains("b"))
                {
                    txt = "<b>" + txt + "</b>";
                }
                if (bi.Contains("i"))
                {
                    txt = "<i>" + txt + "</i>";
                }
            }
            else
            {
                Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 250, 0, 0, "ERROR: Debug (italica, negrilla)"));
            }
        }
        //Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", rgb[0], rgb[1], rgb[2], txt));
        if (size != 0)
        {
            txt = string.Format("<size={0}>{1}</size>", size, txt);
        }
        /* or a bit longer: (stringArray.Any(s => stringToCheck.Contains(s))) */
        for (int i = 0; i < colStrings.Length; i++)
        {
            if (color == colStrings[i])
            {
                colBool = true;
            }
        }
        if (color == "" || colBool)
        {
            if (color == "red")
            {
                rgb[0] = 255;
                rgb[1] = 0;
                rgb[2] = 0;
            }
            else if (color == "green")
            {
                rgb[0] = 0;
                rgb[1] = 255;
                rgb[2] = 0;
            }
            else if (color == "blue")
            {
                rgb[0] = 0;
                rgb[1] = 0;
                rgb[2] = 255;
            }
            else if (color == "yellow")
            {
                rgb[0] = 255;
                rgb[1] = 255;
                rgb[2] = 0;
            }
            else if (color == "cyan")
            {
                rgb[0] = 0;
                rgb[1] = 255;
                rgb[2] = 255;
            }
            else if (color == "magenta")
            {
                rgb[0] = 255;
                rgb[1] = 0;
                rgb[2] = 255;
            }
            else if (color == "orange")
            {
                rgb[0] = 255;
                rgb[1] = 69;
                rgb[2] = 0;
            }
        }
        else
        {
            Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", 250, 0, 0, "ERROR: Debug (not valid color)"));
            return;
        }
        Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", rgb[0], rgb[1], rgb[2], txt));
    }
}
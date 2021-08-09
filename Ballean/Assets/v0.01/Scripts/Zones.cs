using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour
{
    public Map[] maps;
    public Sprite[] clouds;
    public Sprite[] mountains;
    public Sprite[] pathsA;
    public Sprite[] pathsB;

    public bool[] goodEndingPath;
    public bool[] level0, level1, level2, level3, level4, level5, level6, level7, level8;
    public bool[] optionsSelected;

    public int currentMap;

    public GameObject ball;

    public Transform inicialPos;

    // Start is called before the first frame update
    void Start()
    {
        SearchForSprites();

        MapGenerator();       
        SetMapPos();

        SetBoolsArrays();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SearchForSprites()
    {

    }
    void MapGenerator()
    {
        for (int i=1; i <= 37; i++)
        {
            maps[i].clouds = clouds[1];
            maps[i].mountains = mountains[1];
            maps[i].pathA = pathsA[1];
            maps[i].pathB = pathsB[1];
        }
    }
    void SetMapPos()
    {
        for (int i=1; i <= 37; i++ )
        {
            maps[i].yPosClouds = Random.Range(0f, 6.69f);
            maps[i].yPosMountains = Random.Range(0f, 6.69f);
            maps[i].yPospaths = Random.Range(0f, 6.69f);
        }
        SetEndingMap();
    }
    void SetEndingMap()
    {
        maps[37].yPosClouds = 0f;
        maps[37].yPosMountains = 0f;
        maps[37].yPospaths = 0f;
    }
    /********************************************************************************************/
    static void NextMap()
    {
        /*
        if (ball.goingUp)
        {

        }
        else if (ball.goingUp!)
        {
            
        }
        */
    }
    /********************************************************************************************/

    void CheckForRoute()
    {

    }
    void SetBoolsArrays()
    {
        SetGoodEndingPath();
        SetLevels();
    }
    void SetGoodEndingPath()
    {
        goodEndingPath[1]  = true;
        goodEndingPath[2]  = false;
        goodEndingPath[3]  = true;
        goodEndingPath[4]  = true;
        goodEndingPath[5]  = true;
        goodEndingPath[6]  = false;
        goodEndingPath[7]  = true;
        goodEndingPath[8]  = true;
        goodEndingPath[9]  = true;
        goodEndingPath[10] = true;
        goodEndingPath[11] = false;
        goodEndingPath[12] = false;
        goodEndingPath[13] = true;
        goodEndingPath[14] = true;
        goodEndingPath[15] = true;
        goodEndingPath[16] = true;
        goodEndingPath[17] = false;
        goodEndingPath[18] = false;
        goodEndingPath[19] = false;
        goodEndingPath[20] = false;
        goodEndingPath[21] = false;
        goodEndingPath[22] = false;
        goodEndingPath[23] = false;
        goodEndingPath[24] = false;
        goodEndingPath[25] = true;
        goodEndingPath[26] = true;
        goodEndingPath[27] = false;
        goodEndingPath[28] = true;
        goodEndingPath[29] = true;
        goodEndingPath[30] = true;
        goodEndingPath[31] = false;
        goodEndingPath[32] = true;
        goodEndingPath[33] = true;
        goodEndingPath[34] = true;
        goodEndingPath[35] = true;
        goodEndingPath[36] = true;
        goodEndingPath[37] = true;
    }
    void SetLevels()
    {
        SetLevel0();
        SetLevel1();
        SetLevel2();
        SetLevel3();
        SetLevel4();
        SetLevel5();
        SetLevel6();
        SetLevel7();
        SetLevel8();
    }
    void SetLevel0()
    {
        level0[25] = true;
    }
    void SetLevel1()
    {
        level1[1]  = true;
        level1[3]  = true;
        level1[5]  = true;
        level1[23] = true;
        level1[25] = true;
        level1[27] = true;
    }
    void SetLevel2()
    {
        level2[2]  = true;
        level2[4]  = true;
        level2[6]  = true;
        level2[8]  = true;
        level2[10] = true;
        level2[22] = true;
        level2[26] = true;
        level2[29] = true;
    }
    void SetLevel3()
    {
        level3[5]  = true;
        level3[7]  = true;
        level3[9]  = true;
        level3[11] = true;
        level3[13] = true;
        level3[21] = true;
        level3[29] = true;
        level3[31] = true;
    }
    void SetLevel4()
    {
        level4[8]  = true;
        level4[13] = true;
        level4[14] = true;
        level4[16] = true;
        level4[20] = true;
        level4[30] = true;
        level4[32] = true;
    }
    void SetLevel5()
    {
        level5[9] = true;
        level5[11] = true;
        level5[13] = true;
        level5[15] = true;
        level5[17] = true;
        level5[19] = true;
        level5[33] = true;
    }
    void SetLevel6()
    {
        level6[10] = true;
        level6[14] = true;
        level6[10] = true;
        level6[18] = true;
        level6[34] = true;
    }
    void SetLevel7()
    {
        level7[15] = true;
        level7[17] = true;
        level7[19] = true;
        level7[21] = true;
        level7[23] = true;
        level7[35] = true;
    }
    void SetLevel8()
    {
        level8[16] = true;
        level8[22] = true;
        level8[24] = true;
        level8[36] = true;
    }
}

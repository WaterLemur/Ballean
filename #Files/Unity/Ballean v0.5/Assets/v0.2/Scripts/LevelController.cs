using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public enum Choise { Null, 
                         GoodEnding,
                         BadEnding,
                         Defeat }

    public int sizeX, sizeY = new int;
    public Choise[,] choises = new Choise[sizeX,sizeY];
                                                            // Display hud of choises when ball
    public int numberOfLevels, numberOfChoises = 1;
    public int[] levelArray = new int[numberOfLevels, numberOfChoises];
    // Start is called before the first frame update
    void Start()
    {
        PopulateNull();
        PopulateDefeat();
        PopulateBadEnding();
        PopulateGoodEding();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void PopulateNull()
    {
        choises = Choise.Null;
    }
    void PopulateDefeat()
    {

    }
    void PopulateBadEnding()
    {

    }
    void PopulateGoodEding()
    {

    }
}

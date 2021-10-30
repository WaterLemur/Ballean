using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text[] txt;
    public Image[] imgsFront;
    public Image[] imgsBack;
    public Image[] imgsBranches;

    public PlayerController playerScript;
    public LevelController levelController;

    // Start is called before the first frame update
    void Start()
    {
        // asign shit
    }

    // Update is called once per frame
    void Update()
    {
        // update shot
        FeelTheDanger();


        //ScorePerFrame();
    }
    void BrachDisplay()
    {
        // show past selection
        // show current paths
        // show future?
    }
    void FeelTheDanger()
    {
        // img danger alpha increase over time till 0.25??
    }
    void ScorePerFrame()
    {
        txt[0].text = playerScript.vidas.ToString();
        txt[1].text = playerScript.collectedAnts.ToString();
        txt[2].text = playerScript.collectedLavas.ToString();
        txt[3].text = playerScript.collectedBugs.ToString();
    }
    public void UpdateScore(string who)
    {
        if(who == "lifes")
        {
            txt[0].text = playerScript.vidas.ToString();
        }
        else if(who == "ant")
        {
            txt[1].text = playerScript.collectedAnts.ToString();
        }
        else if(who == "larvae")
        {
            txt[2].text = playerScript.collectedLavas.ToString();
        }
        else if(who == "bug")
        {
            txt[3].text = playerScript.collectedBugs.ToString();
        }
        else
        {
            ConsoleText.Print("bi", "red", "ERROR: sumar numero imagen hud", 0);
        }
    }
}

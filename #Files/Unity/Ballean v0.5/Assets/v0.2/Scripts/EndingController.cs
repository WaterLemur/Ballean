using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingController : MonoBehaviour
{
    /*////////////////////////    SCORE    /////////////////////////
    TEXT
    text
    text
    image []
    Text[]

    UIController Ref ++++++++*/
    byte[] totalCapturedArray = new byte[3]; // [ Coyote, Arianna, Crocodile/Swamp ]
    byte[] totalItemsCollected = new byte[3];// [ Larvae, Bug, Ant ]
    byte vidasJugadas;
    GameObject player;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.Find("Player");               ///////////////////////////// get values plantilla
        // PlayerController playerScript = player.GetComponent<PlayerController>();
        // player.Health -= 10.0f;

        Score();
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Score()
    {
        totalItemsCollected[0] = playerController.collectedLavas;
        totalItemsCollected[1] = playerController.collectedBugs;
        totalItemsCollected[2] = playerController.collectedAnts;

        totalCapturedArray = playerController.capturedArray;
        vidasJugadas = playerController.vidas;

        //totalCapturedArray[1] = PlayerController.capturedArray[1];
        //totalCapturedArray[2] = PlayerController.capturedArray[2];
    }
}

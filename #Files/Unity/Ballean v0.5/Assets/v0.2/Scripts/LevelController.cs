using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public enum Choise { Null,   // Sheet = 0
                         GoodEnding, //   = 1
                         BadEnding, //    = 2
                         Defeat } //      = 3
    public Choise[,] choise = new Choise[1,1];
    byte[] playerCoordinate = new byte[2]; // {x,y}
    byte[] startCoordinate = new byte[2];
    byte[] endCoordinate = new byte[2]; // Sheet = 4
    public Transform posPlayerNewGame; 
    public Transform posPlayerUp, posPlayerDown, posCoyote, posFalcon;

    GameObject player;
    public bool goingUp = true;

    public SpriteRenderer dia, noche;
    Color tempColor;
    public PlayerController playerController;

    public GameObject finalLevelGO;

    Transform tmpTrans;

    // Start is called before the first frame update
    void Start()
    {
        finalLevelGO.SetActive(false);

        player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Reiniciar() /// re-launch the game ?
    {
        //player.transform.position = posPlayerNewGame.position;     BUG
        playerController.hpFull = true;
        playerController.capturedArray = new byte[3];
        playerController.itemsCollected = new byte[3];
        /*
        CoyoteController.Reset();
        FalconController.Reset();
        */
    }
    void SiguienteNivel()
    {
        if (goingUp)
        {
            playerCoordinate[0] += 1;
            playerCoordinate[1] += 1;
            player.gameObject.transform.position = posPlayerUp.position;
        }
        else
        {
            playerCoordinate[0] += 1;
            playerCoordinate[1] -= 1;
            player.transform.position = posPlayerDown.position;
        }
        if(playerCoordinate == endCoordinate)
        {
            UltimoNivel();
        }
        Anochecer();
    }
    void UltimoNivel()
    {
        finalLevelGO.SetActive(true);
    }
    void Anochecer()
    {
        tempColor = dia.color;
        tempColor.a -= 0.15f;
        dia.color = tempColor;

        tempColor = noche.color;
        tempColor.a += 0.15f;
        noche.color = tempColor;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            SiguienteNivel();
        }
    }
}

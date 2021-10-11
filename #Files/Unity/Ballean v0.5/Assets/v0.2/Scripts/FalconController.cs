using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalconController : MonoBehaviour
{
    public GameObject falcon;
    public SpriteRenderer sr;

    public Transform posStart;
    public Transform posEnd;
    private Transform posNext;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        posNext = posEnd;
    }

    // Update is called once per frame
    void Update()
    {      
        falcon.transform.position = Vector2.MoveTowards(falcon.transform.position, 
                                                        posNext.position, 
                                                        Time.deltaTime*speed);
        
        if (falcon.transform.position == posNext.position)
        {
            posNext = posNext == posEnd ? posStart : posEnd;
         
            if (posNext == posEnd)
            {
                sr.flipX = false;
            }
            else
            {
                sr.flipX = true;
            }
        }
    }

    /*

    ////////////////////////////////collide whit player

    collision()
    {
        if (colision whit player)
        // player.hpFull = false;
        // player.Captured();
    }

    */
}

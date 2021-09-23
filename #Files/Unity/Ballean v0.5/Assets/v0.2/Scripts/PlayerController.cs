using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.9f;
    int rotationAngle = 120;
    public bool isRolling = false;

    public bool goingUp = true;
    public GameObject armadillo;

    float speedWalking = 4.2f;
    float speedRolling = 6.9f;

    public float JumpHeight;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Ball").active = !true; ///////////// ⚠️to delete⚠️
        
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, JumpHeight);
        }*/
        Jump();
        Ball();

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)) 
        {
            isRolling = !false; 

            speed = speedRolling;
            // set sprite to rolling (ball) 
            
            float horizontal = 1f;
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            transform.position = position;           
        }
        else
        {
            isRolling = !true;

            speed = speedWalking;
            // set sprite to iddle (2 sprite-Walking)           
        }

            /*        ///////////////////////////// MOVIMIENTO //////////////////////////////////////////
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))         
        {  
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
            {
                armadillo.transform.Rotate(new Vector3(0, 0, -rotationAngle*speed) * Time.deltaTime);   
            }
            else 
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
                {
                    armadillo.transform.Rotate(new Vector3(0, 0, -rotationAngle * speed) * Time.deltaTime);
                }
                else
                {
                    //a
                }
            }
        }*/

        // ****************************** Rodar ***************************************************
        if (isRolling)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
            {
                goingUp = true;
            }
            else 
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
                {
                    goingUp = false;
                }
                else
                {
                    
                }
            }          
        }
        // ****************************** Rodar ***************************************************
        else
        {
            //a
        }
    }
    void Ball()
    {
        if (isRolling)
        {
            //set sprite to ball
        }
        else
        {
            // set sprite to humanoid form
        }
    }
    /*void Movement(bool rotation)
    {
        if (rotation)
        {
            speed = speedRolling;
        }
        else
        {
            speed = speedWalking;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))         
        {  
            float horizontal = 1f;
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            transform.position = position;   

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
            {
                armadillo.transform.Rotate(new Vector3(0, 0, -rotationAngle*speed) * Time.deltaTime);   
            }
            else 
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
                {
                    armadillo.transform.Rotate(new Vector3(0, 0, -rotationAngle * speed) * Time.deltaTime);
                }
                else
                {
                    //a
                }
            }
        }
        else
        {
            
        } 
    }*/
    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpHeight);
        }
        ///////////////////////////////////MOVIMIENTO VIDEOS ///////////////////////////////
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            rb.transform.localScale = new Vector2(1, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            rb.transform.localScale = new Vector2(-1, 1);
        }
        ///////////////////////////////////MOVIMIENTO VIDEOS ///////////////////////////////
        /*
        if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isRolling)
            {
                rb.velocity = new Vector2(0, JumpHeight);
            }
            else
            {
                rb.velocity = new Vector2(0, JumpHeight);
            }
        }
        else
        {
            //a
        }*/
    }
    void Captured()
    {
        // Restart
    }
}
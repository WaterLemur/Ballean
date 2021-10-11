using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool hpFull = true;

    public bool isRolling = false;
    public bool goingUp = true;

    public float speedWalking = 4.20f;
    public float speedRolling = 6.9f;
    public float jumpWalking = 4.20f;
    public float jumpRolling = 6.9f;
    int rotationAngle = 120;
    int speedTimer = 0;

    private GameObject hat, tie;
    private Rigidbody2D rb;
    private Animator anim;

    enum capEnum {Coyote = 1, Arianna, Crocodile};
    byte[] capturedArray = new byte[3]; // [ Coyote, Arianna, Crocodile/Swamp ]

    byte[] itemsCollected = new byte[3];// [ Larvae, Bug, Ant ]

    Transform posStart;

    //////////////////////////////// UI ///////////////////////////////////////////

    //////////////////////////////// UI ///////////////////////////////////////////

    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        hat = GameObject.Find("Hat");
        tie = GameObject.Find("Tie");

        posStart = GameObject.Find("Position Start Player").GetComponent<Transform>();

        anim.Play("Iddle");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speedTimer);
        Jump();
        ////////////*****////////////     PATH     ////////////*****////////////
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) ||
            Input.GetKey("right")   || Input.GetKey("up"))
        {
            goingUp = true;
        }
        else
        {
            goingUp = false;
        }
        ////////////*****////////////   MOVEMENT   ////////////*****////////////
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)  ||  Input.GetKey("right") || Input.GetKey("up") ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)  ||  Input.GetKey("left")  || Input.GetKey("down"))
        {
            float speed;
            speedTimer++;

            if (speedTimer >= 200)
            {      
                anim.Play("Roll");
                isRolling = true;
                speed = 6.9f;

                hat.SetActive(false);  tie.SetActive(false);              
                transform.Rotate(new Vector3(0, 0, -rotationAngle * 4.20f) * Time.deltaTime);
                
                speedTimer = 200;
            } 
            else
            {
                anim.Play("Walk");
                isRolling = false;
                speed = 4.20f;

                hat.SetActive(true);  tie.SetActive(true);
                transform.rotation = Quaternion.identity;
            }
            float horizontal = 1f;
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            transform.position = position;           
        }
        else
        {
            Debug.Log("Not pressed!!!");
            anim.Play("Iddle");
            isRolling = false;

            hat.SetActive(true); tie.SetActive(true);
            transform.rotation = Quaternion.identity;

            speedTimer--;
            speedTimer = speedTimer <= 0 ? 0 : speedTimer;
        }
        Debug.Log("update");
    } 

    void Reset()
    {
        this.transform.position = posStart.position;
        hpFull = true;
        capturedArray = new byte[3];
        itemsCollected = new byte[3];
        /*
        CoyoteController.Reset();
        FalconController.Reset();
        */
    }

    void Captured(capEnum captor)
    {
        if (hpFull == false)
        {
            if (captor == capEnum.Coyote)
            {
                capturedArray[0]++;
            }
            else if (captor == capEnum.Arianna)
            {
                capturedArray[1]++;
            }
            else if (captor == capEnum.Crocodile)
            {
                capturedArray[2]++;
            }
            Reset(); 
        }    
    }

    void Jump()
    {
        float jumpSpeed = 0f;
        jumpSpeed = isRolling ? jumpRolling : jumpWalking;

        if (isRolling)
        {
            jumpSpeed = jumpRolling;
        }
        else
        {
            jumpSpeed = jumpWalking;
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
    
    void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log(c.gameObject.tag);
    }
}
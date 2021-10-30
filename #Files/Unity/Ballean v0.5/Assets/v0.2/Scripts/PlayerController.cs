using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hpFull = true;
    public byte vidas = new byte(); 

    public bool isRolling = false;

    public float speedWalking = 4.20f;
    public float speedRolling = 6.9f;
    public float jumpWalking = 4.20f;
    public float jumpRolling = 6.9f;
    float jumpSpeed = new float();
    byte rotationAngle = 120;
    byte speedTimer = 0;

    public SpriteRenderer hat, tie, bow;
    private Rigidbody2D rb;
    private Animator anim;

    public byte collectedAnts, collectedBugs, collectedLavas;

    enum capEnum {Coyote = 1, Arianna, Crocodile};
    public byte[] capturedArray = new byte[3]; // [ Coyote, Arianna, Crocodile/Swamp ]

    public byte[] itemsCollected = new byte[3];// [ Larvae, Bug, Ant ]

    public HUDController hudController;
    public LevelController levelController;
    public ItemController iController;

    //////////////////////////////// UI ///////////////////////////////////////////

    //////////////////////////////// UI ///////////////////////////////////////////
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        anim.Play("Iddle");
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        ////////////*****////////////     PATH     ////////////*****////////////
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) ||
            Input.GetKey("right")   || Input.GetKey("up"))
        {
            levelController.goingUp = true;
        }
        else
        {
            levelController.goingUp = false;
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

                hat.color = new Color(hat.color.r, hat.color.g, hat.color.b, 0f);
                bow.color = new Color(bow.color.r, bow.color.g, bow.color.b, 0f);
                tie.color = new Color(tie.color.r, tie.color.g, tie.color.b, 0f);
                transform.Rotate(new Vector3(0, 0, -rotationAngle * 4.20f) * Time.deltaTime);
                
                speedTimer = 200;
                ConsoleText.Print("i", "red", " - - - - - - - - - - - - - - - - - - - - - - - - - - - - Rolling!", 13); 
                                
            } 
            else
            {
                anim.Play("Walk");
                isRolling = false;
                speed = 4.20f;

                hat.color = new Color(hat.color.r, hat.color.g, hat.color.b, 1f);
                bow.color = new Color(bow.color.r, bow.color.g, bow.color.b, 1f);
                tie.color = new Color(tie.color.r, tie.color.g, tie.color.b, 1f);
                transform.rotation = Quaternion.identity;

                ConsoleText.Print("i", "orange", " - - - - - - - - - - - - - - - - - - - - - - - - - - - - Walking ...", 13); 
                
            }
            float horizontal = 1f;
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            transform.position = position;           
        }
        else
        {
            ConsoleText.Print("i", "yellow", " - - - - - - - - - - - - - - - - - - - - - - - - - - - - AFK", 13);
            anim.Play("Iddle");
            isRolling = false;

            hat.color = new Color(hat.color.r, hat.color.g, hat.color.b, 1f);
            bow.color = new Color(bow.color.r, bow.color.g, bow.color.b, 1f);
            tie.color = new Color(tie.color.r, tie.color.g, tie.color.b, 1f);
            transform.rotation = Quaternion.identity;

            speedTimer--;
            speedTimer = speedTimer <= 0 ? (byte)0 : speedTimer;
        }
    } 
    void Jump()
    {       
        jumpSpeed = isRolling ? jumpRolling : jumpWalking;
        if (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(rb.velocity.y, jumpSpeed);
        }
    }
    void Captured(capEnum captor)
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
        vidas++;
        levelController.Reiniciar();
        transform.position = levelController.posPlayerNewGame.position;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug: con quien colisiona?
        ConsoleText.Print("b", "orange", "COLLISION:  " + other.gameObject.name + "  -  TAG:  " + other.gameObject.tag, 0);
        //Cojer objeto
        if (other.gameObject.tag == "Collectable")
        {
            if(other.gameObject.GetComponent<ItemController>().item == ItemController.Items.Larvae)
            {
                collectedLavas++;
                hudController.UpdateScore("larvae");
            }
            else if (other.gameObject.GetComponent<ItemController>().item == ItemController.Items.Bug)
            {
                collectedBugs++;
                hudController.UpdateScore("bug");
            }
            else if (other.gameObject.GetComponent<ItemController>().item == ItemController.Items.Ant)
            {
                collectedAnts++;
                hudController.UpdateScore("ant");
            }
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            hpFull = false;
            if(other.gameObject.GetComponent<CoyoteController>())
            {
                Captured(capEnum.Coyote);
                // Capturado por el coyote
            }
            else if (other.gameObject.GetComponent<FalconController>())
            {
                Captured(capEnum.Arianna);
                // Capturado por la alcón
            }
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            hpFull = false;
            Captured(capEnum.Crocodile);
            // Atrapado en el pantando
        }
    }
}
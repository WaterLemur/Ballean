using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 6.9f;
    public int rotationAngle = 120;

    public int level = 1;

    public GameObject ball;

    public bool goingUp = true;

    public Transform inicialPos;

    public Collider2D pathA;
    public Collider2D pathB;

    // Start is called before the first frame update
    void Start()
    {
        SetPosToStart();

        ball.transform.rotation = Quaternion.Euler(Vector3.forward * 90);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            goingUp = true;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            goingUp = false;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {  
            float horizontal = 1f;
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;
            transform.position = position;   
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            ball.transform.Rotate(new Vector3(0, 0, -rotationAngle*speed) * Time.deltaTime);
            
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            ball.transform.Rotate(new Vector3(0, 0, -rotationAngle * speed) * Time.deltaTime);
        }
    }  
    public void SetPosToStart()
    {
        pathA.enabled = true;
        pathB.enabled = true;

        transform.position = inicialPos.position;    
    }

    void OnTriggerEnter2D(Collider2D col2d)
    {
        if (col2d.name == "Change Path HitBox")
        {
            ChangePathHitBox();
        }
        else if (col2d.name == "ChangeLevelCollider")
        {         
            SetPosToStart();            
        }
    }
    void ChangePathHitBox()
    {
        if (goingUp)
        {
            pathA.enabled = true;
            pathB.enabled = false;
        }
        else if(!goingUp)
        {
            pathA.enabled = false;
            pathB.enabled = true;
        }
    }
}

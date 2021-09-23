using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 1f;
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        transform.position = position;
    }

    // if collider whit player
    //deth
}

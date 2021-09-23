using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalconController : MonoBehaviour
{
    public GameObject falcon;
    public Transform pos_start;
    public Transform pos_end;
    private Transform pos_next;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        pos_next = pos_end;
    }

    // Update is called once per frame
    void Update()
    {
        falcon.transform.position = Vector2.MoveTowards(falcon.transform.position, 
                                                        pos_next.position, 
                                                        Time.deltaTime*speed);
        
        if (falcon.transform.position == pos_next.position)
        {
            pos_next = pos_next == pos_end ? pos_start : pos_end;
        }

        /*                 /////////////////////////////////////////// DEBUG ERROR /////////////////////////
                                                                    NOT MOVING
        if (falcon.transform.position == pos_end.position)
        {
            Debug.Log("✓");
        }
        else
        {
            Debug.Log("✗");
        }
        */
    }
}

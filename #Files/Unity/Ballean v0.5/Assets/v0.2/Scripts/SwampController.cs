using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampController : MonoBehaviour
{
    public GameObject player;
    public GameObject crocoClosed, crocoOpen;

    bool isCrocoOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when colision 1(near) whit player
            // on sprite open mouth
            // off sprite closed mouth
        // when collision 2 (eat) whit player
            // on sprite closed mouth
            // off sprite open mouth
    }
}

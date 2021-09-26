using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameObject shine;
    SpriteRenderer sr;

    public Sprite ant, bug, larvae;

    void Update()
    {
        shine.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
    }

    void Start()
    {
        shine = transform.Find("Shine").gameObject;
        sr = GetComponent<SpriteRenderer>();

        Random_Item();
    }

    void Random_Item()
    {
        int this_Item = Random.Range(0,3);      
        if (this_Item == 0)
        {
            sr.sprite = ant;
        }
        else
        {
            if (this_Item == 1)
            {
                sr.sprite = bug;
            }
            else
            {
                if (this_Item == 2)
                {
                    sr.sprite = larvae;
                }
            }
        }
    }
}

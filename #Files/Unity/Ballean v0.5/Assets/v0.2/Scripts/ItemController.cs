using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public enum Items { Larvae, Bug, Ant };
    public Items item = new Items();
    public byte itemSelector;

    GameObject shine;
    SpriteRenderer sr;
    public Sprite[] items;

    void Update()
    {
        // Rotacion de la imagen de fondo
        shine.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
    }

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        shine = transform.Find("Shine").gameObject;

        SetItem("bug"); //     de-bug     gggggggggggggggggggggggggggggggggggggggggggggg        
    }

    void SetItem(string who)
    
    {
        if(who == "larvae")
        {
            sr.sprite = items[0];
            item = Items.Larvae;
        }
        else if (who == "bug")
        {
            sr.sprite = items[1];
            item = Items.Bug;
        }
        else if (who == "ant")
        {
            sr.sprite = items[2];
            item = Items.Ant;
        }
    }
}

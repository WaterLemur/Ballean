using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public enum Items { Larvae, Bug, Ant };
    public Items item = new Items();

    GameObject shine;
    SpriteRenderer sr;

    Sprite larvae, bug, ant;

    void Update()
    {
        shine.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
    }

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        larvae = Resources.Load<Sprite>("Images/Items_01/Items_02") as Sprite;
        bug = Resources.Load<Sprite>("Images/Items_01/Items_01_1") as Sprite;
        ant = Resources.Load<Sprite>("Images/Items_01/Items_01_0") as Sprite;

        if (larvae == Resources.Load<Sprite>("Images/Items_01"))
        {
            Debug.Log("SPRIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIITE");        
        }

        shine = transform.Find("Shine").gameObject;


        sr.sprite = (item == Items.Larvae) ? sr.sprite = larvae : null;
        sr.sprite = (item == Items.Bug) ? sr.sprite = bug : null;
        sr.sprite = (item == Items.Ant) ? sr.sprite = ant : null;

        RandomItem();////////    DEBUGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
    }
////////////////////////////////////////    DEBUGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
    void RandomItem()
    {
        byte itemSelector = (byte)Random.Range(0,3);
        if (itemSelector == 0)
        {
            sr.sprite = larvae;
        }
        else if (itemSelector == 1)
        {
            sr.sprite = bug;
        }
        else if (itemSelector == 2)
        {
            sr.sprite = ant;
        }
    }

    /*
        collision ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        
        if collide whit player
        {
            player.itemsCollected[ (int)item ]++;     
        }
    */
}

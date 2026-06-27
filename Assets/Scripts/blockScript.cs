using System;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public static Boolean before = true;
    public static int pressed = -1;
    public static String blockType = "cond";
    private bool switched = false;
    [SerializeField] private makerScript ecaMaker;
    [SerializeField] private golMakerScript golMaker;
    [SerializeField] private llMakerScript llMaker;
    [SerializeField] private wwMakerScript wwMaker;
    public int pos, pos2, type;

    void Update()
    {
        
        if (!before)
        {
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(transform.Find("highlight").gameObject);
            Destroy(GetComponent<blockScript>());
        }
        if (pressed == -1 && switched) switched = false;
    }

    private void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().color.Equals(Color.white)) pressed = 0;
        else pressed = 1;
    }

    void OnMouseUp()
    {
        pressed = -1;
        switched = false;
    }

    private void OnMouseOver()
    {
        if (transform.Find("highlight").gameObject.activeSelf == false)
        {
            transform.Find("highlight").gameObject.SetActive(true);
        }
        if (pressed == 0 && !switched && (before || type == 2))
        {
            GetComponent<SpriteRenderer>().color = Color.black;
            if (type == 1) ecaMaker.world[pos] = 1;
            else if (type == 2) golMaker.world[pos][pos2] = 1;
            else if (type == 3) llMaker.world[pos][pos2] = 1;
            switched = true;
        }
        else if (pressed == 1 && !switched && (before || type == 2))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            if (type == 1) ecaMaker.world[pos] = 0;
            else if (type == 2) golMaker.world[pos][pos2] = 0;
            else if (type == 3) llMaker.world[pos][pos2] = 0;
            switched = true;
        }
        if (type == 4)
        {
            if (pressed == 1 && !switched)
            {
                if (blockType.Equals("cond")) {
                    GetComponent<SpriteRenderer>().color = Color.yellow;
                    wwMaker.world[pos][pos2] = 1;
                }
                else if (blockType.Equals("head")) 
                {
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    wwMaker.world[pos][pos2] = 2;
                }
                else if (blockType.Equals("tail")) {
                    GetComponent<SpriteRenderer>().color = Color.red;
                    wwMaker.world[pos][pos2] = 3;
                }
                else {
                    GetComponent<SpriteRenderer>().color = Color.black;
                    wwMaker.world[pos][pos2] = 0;
                }
                switched = true;
            }
        }
    }

    private void OnMouseExit()
    {
        if (transform.Find("highlight").gameObject.activeSelf == true)
        {
            transform.Find("highlight").gameObject.SetActive(false);
        }
    }
}

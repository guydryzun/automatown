using System;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public static Boolean before = true, pressed = false;
    private bool switched = false;
    [SerializeField] private makerScript ecaMaker;
    [SerializeField] private golMakerScript golMaker;
    [SerializeField] private llMakerScript llMaker;
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
        if (!pressed && switched) switched = false;
    }

    private void OnMouseDown()
    {
        pressed = true;
    }

    void OnMouseUp()
    {
        pressed = false;
        switched = false;
    }

    private void OnMouseOver()
    {
        if (transform.Find("highlight").gameObject.activeSelf == false)
        {
            transform.Find("highlight").gameObject.SetActive(true);
        }
        if (pressed && !switched && (before || type == 2))
        {
            if (GetComponent<SpriteRenderer>().color.Equals(Color.white))
            {
                GetComponent<SpriteRenderer>().color = Color.black;
                if (type == 1) ecaMaker.world[pos] = 1;
                else if (type == 2) golMaker.world[pos][pos2] = 1;
                else if (type == 3) llMaker.world[pos][pos2] = 1;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Color.white;
                if (type == 1) ecaMaker.world[pos] = 0;
                else if (type == 2) golMaker.world[pos][pos2] = 0;
                else if (type == 3) llMaker.world[pos][pos2] = 0;
            }
            switched = true;
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

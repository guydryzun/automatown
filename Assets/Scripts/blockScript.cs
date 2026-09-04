using System;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public static Boolean before = true;
    [SerializeField] public static int pressed = -1; //delete the serializeField after debugging is done
    [SerializeField] private bool switched = false; //delete the serializeField after debugging is done
    [SerializeField] private makerScript ecaMaker;
    [SerializeField] private golMakerScript golMaker;
    [SerializeField] private llMakerScript llMaker;
    [SerializeField] private wwMakerScript wwMaker;
    public int pos, pos2, type;
    private Color yellow = new Color(1f, 0.8627450980392157f, 0.2901960784313726f), blue = new Color(0.396078431372549f, 0.615686274509804f, 0.9490196078431372f), red = new Color(0.9725490196078431f, 0.25882352941176473f, 0.25882352941176473f);


    void Update()
    {
        
        if (!before && type == 1)
        {
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(transform.Find("highlight").gameObject);
            Destroy(GetComponent<blockScript>());
        }
        if (pressed == -1 && switched) switched = false;
        if (type == 4) before = false;
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
                if (wwMaker.current == 1) {
                    GetComponent<SpriteRenderer>().color = yellow;
                }
                else if (wwMaker.current == 2) 
                {
                    GetComponent<SpriteRenderer>().color = blue;
                }
                else if (wwMaker.current == 3) {
                    GetComponent<SpriteRenderer>().color = red;
                }
                else {
                    GetComponent<SpriteRenderer>().color = Color.black;
                }
                wwMaker.world[pos][pos2] = wwMaker.current;
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

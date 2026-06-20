using System;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public static Boolean before = true;
    [SerializeField] private makerScript maker;
    public int pos;

    void Update()
    {
        
        if (!before)
        {
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(transform.Find("highlight").gameObject);
            Destroy(GetComponent<blockScript>());
        }
        
    }

    private void OnMouseDown()
    {
        if (before)
        {
            if (GetComponent<SpriteRenderer>().color.Equals(Color.white))
            {
                GetComponent<SpriteRenderer>().color = Color.black;
                maker.world[pos] = 1;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Color.white;
                maker.world[pos] = 0;
            }
        }
    }

    private void OnMouseOver()
    {
        if (transform.Find("highlight").gameObject.activeSelf == false)
        {
            transform.Find("highlight").gameObject.SetActive(true);
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

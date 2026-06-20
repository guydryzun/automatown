using System;
using UnityEngine;

public class makerScript : MonoBehaviour
{
    [SerializeField] private GameObject block, cam;
    public int len, r, start = 0;
    [SerializeField] private ObjectPool pool;
    [SerializeField] private GameObject[] loadingScreen;
    public int[] world;
    private int loading = 0;

    private void Start()
    {
        Vector3 p = block.transform.position;
        world = new int[len];
        if (start > 0) world[start] = 1;
        else if (start == -1)
        {
            System.Random random = new System.Random();
            for (int i = 0; i < world.Length; i++) world[i] = random.Next(0, 2);
        }
        for (int i = 0; i < world.Length; i++)
        {
            Vector3 newT = new Vector3(transform.position.x + 0.1f * i, transform.position.y, transform.position.z);
            GameObject newBlock = Instantiate(block, newT, transform.rotation);
            newBlock.SetActive(true);
            if (world[i] == 1) newBlock.GetComponent<SpriteRenderer>().color = Color.black;
            newBlock.GetComponent<blockScript>().pos = i;
        }
        transform.position = new Vector3(p.x, p.y - 0.1f, transform.position.z);    
    }

    private void Update()
    {
        if (loading == 1)
        {
            Vector3 p = block.transform.position;
            blockScript.before = false;
            for (int i = 0; i < len; i++)
            {
                world = nextGen(world, r);
                foreach (int n in world)
                {
                    GameObject newBlock = pool.GetObject();
                    newBlock.transform.position = transform.position;
                    newBlock.transform.rotation = transform.rotation;
                    newBlock.SetActive(true);
                    if (n == 1) newBlock.GetComponent<SpriteRenderer>().color = Color.black;
                    transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
                }
                transform.position = new Vector3(p.x, transform.position.y - 0.1f, transform.position.z);
            }
            foreach (GameObject obj in loadingScreen) obj.SetActive(false);
            loading = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (GameObject obj in loadingScreen) obj.SetActive(true);
            loading = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                cam.transform.position = new Vector3(cam.transform.position.x + 0.2f, cam.transform.position.y, cam.transform.position.z);
            }
            else
            {
                cam.transform.position = new Vector3(cam.transform.position.x + 0.1f, cam.transform.position.y, cam.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                cam.transform.position = new Vector3(cam.transform.position.x - 0.2f, cam.transform.position.y, cam.transform.position.z);
            }
            else
            {
                cam.transform.position = new Vector3(cam.transform.position.x - 0.1f, cam.transform.position.y, cam.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 0.2f, cam.transform.position.z);
            }
            else
            {
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 0.1f, cam.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 0.2f, cam.transform.position.z);
            }
            else
            {
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 0.1f, cam.transform.position.z);
            }
        }
    }

    public static int[] nextGen(int[] arr, int r)
    {
        int[] newGen = new int[arr.Length], rule = makeRule(r);
        for (int i = 1; i < arr.Length - 1; i++)
        {
            int val = arr[i - 1] * 4 + arr[i] * 2 + arr[i + 1];
            newGen[i] = rule[7 - val];
        }
        newGen[0] = 0;
        newGen[arr.Length - 1] = 0;
        return newGen;
    }

    public static int[] makeRule(int n)
    {
        int index = 0, cur = 0;
        int[] rule = new int[8];
        while (index < 8 && n < Math.Pow(2, 7 - index)) index++;
        while (index < 8)
        {
            if (cur + Math.Pow(2, 7 - index) <= n)
            {
                rule[index] = 1;
                cur += (int)Math.Pow(2, 7 - index);
            }
            index++;
        }
        return rule;
    }
}

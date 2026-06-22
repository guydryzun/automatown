using UnityEngine;

public class golMakerScript : MonoBehaviour
{
    public int[][] world = null, origin = null;
    private GameObject[][] block;
    public GameObject objectPool, cam;
    public int len;
    private float timer = 0f, speed = 0.5f;
    private bool isRunning = false;


    private void Start()
    {
        if (world == null)
        {
            world = new int[len][];
            for (int i = 0; i < len; i++) world[i] = new int[len];
        }
        origin = world;
        block = new GameObject[len][];
        for (int i = 0; i < len; i++) block[i] = new GameObject[len];
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                Vector3 newT = new Vector3(transform.position.x + 0.1f * j, transform.position.y - 0.1f * i, transform.position.z);
                block[j][i] = objectPool.GetComponent<ObjectPool>().GetObject();
                block[j][i].transform.position = newT;
                block[j][i].transform.rotation = transform.rotation;
                block[j][i].SetActive(true);
                block[j][i].GetComponent<blockScript>().type = 2;
                block[j][i].GetComponent<blockScript>().pos = j;
                block[j][i].GetComponent<blockScript>().pos2 = i;
                if (world[j][i] == 1) block[j][i].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isRunning = !isRunning;
        }
        if (isRunning)
        {
            timer += Time.deltaTime;
            if (timer >= speed)
            {
                world = nextGen(world);
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (world[j][i] == 1) block[j][i].GetComponent<SpriteRenderer>().color = Color.black;
                        else block[j][i].GetComponent<SpriteRenderer>().color = Color.white;
                    }
                }
                timer = 0f;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            world = nextGen(world);
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (world[i][j] == 1) block[i][j].GetComponent<SpriteRenderer>().color = Color.black;
                        else block[i][j].GetComponent<SpriteRenderer>().color = Color.white;
                    }
                }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    world[j][i] = origin[j][i];
                    if (world[j][i] == 1) block[j][i].GetComponent<SpriteRenderer>().color = Color.black;
                    else block[j][i].GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            speed += 0.1f;
            if (speed > 5f) speed = 5f;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            speed -= 0.1f;
            if (speed < 0.05f) speed = 0.05f;
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
        if (Input.GetKey(KeyCode.Q))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                cam.GetComponent<Camera>().orthographicSize += 0.2f;
            }
            else
            {
                cam.GetComponent<Camera>().orthographicSize += 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                cam.GetComponent<Camera>().orthographicSize -= 0.2f;
            }
            else
            {
                cam.GetComponent<Camera>().orthographicSize -= 0.1f;
            }
        }
    }

    private static int[][] nextGen(int[][] arr)
    {
        int[][] newGen = new int[arr.Length][];
        for (int i = 0; i < arr.Length; i++) newGen[i] = new int[arr[i].Length];
        for (int i = 1; i < arr.Length - 1; i++)
        {
            for (int j = 1; j < arr[i].Length - 1; j++)
            {
                int sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j - 1] + arr[i][j + 1] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                if (sum == 3) newGen[i][j] = 1;
                else if (sum == 2) newGen[i][j] = arr[i][j];
                else newGen[i][j] = 0;
            }
        }
        return newGen;
    }
}

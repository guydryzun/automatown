using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private Queue<GameObject> pool;

    void Start()
    {
        pool = new Queue<GameObject>();
    }

    public GameObject GetObject()
    {
        if (pool.Count > 0)
        {
            GameObject temp = pool.Dequeue();
            temp.SetActive(true);
            return temp;
        }
        return Instantiate(prefab);
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}

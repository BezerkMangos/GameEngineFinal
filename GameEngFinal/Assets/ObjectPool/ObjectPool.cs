using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

     Queue<GameObject> poolQueue = new Queue<GameObject>();

    private GameObject[] objects; //Changes
    private int size;

    
   
    public ObjectPool(int sizeWanted, GameObject[] pieces)
    {
        
        size = sizeWanted;
        objects = pieces;
        CreatePool();
    }

    public void CreatePool()
    {
        for (int i = 0; i < size; i++)
        {
            int index = Random.Range(0, objects.Length -1);
            GameObject obj = new GameObject(objects[index].name);
            //obj = objects[index];


            poolQueue.Enqueue(obj);
            obj.SetActive(false);
        }
            
    }


    public void GetObj()
    {
       GameObject obj = poolQueue.Dequeue();
       obj.SetActive(true);

    }

    public void ReturnOBJ(GameObject obj)
    {
        obj.SetActive(false);
        poolQueue.Enqueue(obj);
    }


    public int PoolSize()
    {
        return poolQueue.Count;
    }









}

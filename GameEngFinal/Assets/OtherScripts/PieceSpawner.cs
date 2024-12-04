using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSpawner : MonoBehaviour
{

    [SerializeField] int size;
    [SerializeField] GameObject[] pieces; // Changes

    public static ObjectPool pool;

    [SerializeField] GameObject spawnP;


    public int piecesActive;

    private void Start()
    {
        pool = new ObjectPool(size, pieces);
        piecesActive = 0;
        InvokeRepeating("SpawnPiece",1,5);
    }


    void SpawnPiece()
    {
        pool.GetObj();
        piecesActive = piecesActive + 1;
    }


}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PoolObserver : MonoBehaviour
{
    PieceSpawner spawner;

  
    [SerializeField] TextMeshProUGUI piecesLeft;

    void Start()
    {
        spawner = FindObjectOfType<PieceSpawner>();
    }

    
    void Update()
    {
        piecesLeft.text = "Pieces Active: " + spawner.piecesActive.ToString();
    }

}

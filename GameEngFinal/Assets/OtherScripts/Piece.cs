using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    Rigidbody rb;

    bool dirtyFlag = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (dirtyFlag == true)
        {
            gameObject.transform.position = gameObject.transform.position + Vector3.down * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            dirtyFlag = false;
            PieceSpawner.pool.ReturnOBJ(this.gameObject);
        }
    }
}

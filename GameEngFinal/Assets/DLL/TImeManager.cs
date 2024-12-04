using ClassLibrary1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImeManager : MonoBehaviour
{
    PauseTime tFuncs; 
    void Start()
    {
        tFuncs = GetComponent<PauseTime>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            tFuncs.Pause();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            tFuncs.UnPause();
        }

    }
}

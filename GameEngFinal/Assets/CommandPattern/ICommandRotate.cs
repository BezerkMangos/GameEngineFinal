using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ICommandRotate : ICommand
{
    [SerializeField]
    GameObject Target;
    [SerializeField]
    int rotation;

    public ICommandRotate(GameObject obj, int rotate) 
    {
        Target = obj;
        rotation = rotate;
    }



    public void Execute()
    {
        Target.transform.Rotate(0,0,0 + rotation);
    }

    public void Undo()
    {
        Target.transform.Rotate(0,0,0 + (-1f * rotation));
    }



}

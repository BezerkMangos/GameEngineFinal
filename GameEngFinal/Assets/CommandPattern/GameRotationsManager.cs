using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRotationsManager : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    int left = -90;
    int right = 90;

    [SerializeField]
    CommandStack commandStack;

    void Start()
    {
        commandStack = GetComponent<CommandStack>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ICommand command = new ICommandRotate(target,left);
            commandStack.ExecuteCommand(command);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ICommand command = new ICommandRotate(target, right);
            commandStack.ExecuteCommand(command);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            commandStack.UndoCommand();
        }
    }




}

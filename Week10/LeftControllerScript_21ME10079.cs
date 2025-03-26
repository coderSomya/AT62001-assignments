using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftControllerScript_21ME10079 : MonoBehaviour
{
    public InputActionReference primary2DAxis;
    Vector2 movementVector;
    // Start is called before the first frame update
    void Start()
    {
        
        primary2DAxis.action.performed += Primary2DMoved;
        primary2DAxis.action.performed += Primary2DStopped;
    }

    void Primary2DMoved(InputAction.CallbackContext context)
    {
        movementVector = context.ReadValue<Vector2>();
    }

    void Primary2DStopped(InputAction.CallbackContext context)
    {
        movementVector= Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(movementVector);    
    }
}

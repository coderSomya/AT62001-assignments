using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveXZ : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference primary2DAxis;
    Vector2 movementVector;
    public GameObject cam;
    public GameObject right_controller;
    // Start is called before the first frame update
    void Start()
    {

        primary2DAxis.action.performed += Primary2DMoved;
        primary2DAxis.action.canceled += Primary2DStopped;
    }

    void Primary2DMoved(InputAction.CallbackContext context)
    {
        Debug.Log("here atleast");
        movementVector = context.ReadValue<Vector2>();
    }

    void Primary2DStopped(InputAction.CallbackContext context)
    {
        movementVector = Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("before tranform"+ transform.position);
        cam.transform.position += 10*(new Vector3(movementVector.x,0, movementVector.y))*Time.deltaTime;
        Debug.Log(movementVector);
        Debug.Log("after tranform" + transform.position);
    }
}

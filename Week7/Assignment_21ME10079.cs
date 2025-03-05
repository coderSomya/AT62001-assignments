using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Assignment_21ME10079 : MonoBehaviour
{
    public InputActionReference moveActionReference;
    Vector2 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we convert the xy vector to xz as in Unity the y is the vertically up component through which we see
        Vector3 temp = new Vector3(moveVector.x, 0, moveVector.y);
        transform.Translate(Time.deltaTime * temp);
    }

    //this function is related to the input system actions that we have defined
    private void OnEnable()
    {
        moveActionReference.action.Enable();

        moveActionReference.action.performed += Move;
        //this attaches the action
        moveActionReference.action.canceled += Stop;
        //this detaches the action
    }

    void Move(InputAction.CallbackContext value)
    {
        moveVector = value.ReadValue<Vector2>();
        Debug.Log(moveVector);
    }

    void Stop(InputAction.CallbackContext value)
    {
        moveVector = Vector2.zero;
        Debug.Log(moveVector);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Group5_Assignment : MonoBehaviour
{
    // Start is called before the first frame update
    //VARIABLES FOR RAY:
    float rayLength = 500f;
    LineRenderer rayline;
    public Color raycolor = Color.yellow;
    public LayerMask mask;

    public InputActionReference thumbstick;
    Vector2 movementVector;
    public GameObject xr_origin;

    void Start()
    {
        rayline = GetComponent<LineRenderer>();
        rayline.startWidth = 0.01f;
        rayline.endWidth = 0.01f;
        rayline.material = new Material(Shader.Find("Sprites/Default"));
        rayline.startColor = raycolor;
        rayline.endColor = raycolor;


        thumbstick.action.performed += thumbmove;
        thumbstick.action.canceled += thumbstop;
    }

    void thumbmove(InputAction.CallbackContext context)
    {
        Debug.Log("here atleast");
        movementVector = context.ReadValue<Vector2>();
    }

    void thumbstop(InputAction.CallbackContext context)
    {
        movementVector = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {

        //float angle = movementVector.;
        //xr_origin.transform.rotation *= Quaternion.Euler(0,movementVector.y,0);
        xr_origin.transform.Rotate(new Vector3(0,movementVector.y, 0));

        Vector3 rayStart = transform.position;
        Vector3 rayEnd = transform.position + transform.forward * rayLength;
        rayline.enabled = true;
        rayline.startColor = raycolor;
        rayline.endColor = raycolor;
        //Debug.Log("inside update atleast");
        rayline.positionCount = 2;
        rayline.SetPosition(0, rayStart);
        rayline.SetPosition(1, rayEnd);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, rayLength, mask))
        {
            Debug.Log("hit occurred");
            rayline.SetPosition(0, rayStart);
            rayline.SetPosition(1, hitInfo.collider.gameObject.transform.position);
            Debug.Log("got the tag"+hitInfo.collider.gameObject.tag);
            if (hitInfo.collider.gameObject.tag == "enemy")
            {
                rayline.startColor = Color.red;
                rayline.endColor = Color.red;
                Debug.Log("ene");
                if (true)
                {
                    Debug.Log("trying to destroy");
                    Destroy(hitInfo.collider.gameObject);

                    rayline.startColor = Color.yellow;
                    rayline.endColor = Color.yellow;
                }
            }
        }

    }
}

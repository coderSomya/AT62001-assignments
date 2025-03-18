using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Assignment_21ME10079 : MonoBehaviour
{
    public Vector2 turn;


    //VARIABLES FOR RAY:
    float rayLength = 500f;
    public TextMeshProUGUI hitText;
    float distance;
    LineRenderer rayline;
    public Color raycolor = Color.yellow;
    public LayerMask friend_raymask;
    public LayerMask enemy_raymask;


    void Start()
    {
        rayline = GetComponent<LineRenderer>();
        rayline.startWidth = 0.01f;
        rayline.endWidth = 0.01f;
        rayline.material = new Material(Shader.Find("Sprites/Default"));
        rayline.startColor = raycolor;
        rayline.endColor = raycolor;

    }

    void Update()
    {
        //TURN LOGIC:

        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");

        transform.Rotate(0, turn.x, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + 0.01f * transform.forward;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position = transform.position - 0.01f * transform.forward;
        }

        // HIT LOGIC:
        Vector3 rayStart = transform.position;
        Vector3 rayEnd = transform.position + transform.forward * rayLength;
        rayline.enabled = true;
        rayline.startColor = raycolor;
        rayline.endColor = raycolor;


        rayline.SetPosition(0, rayStart);
        rayline.SetPosition(1, rayEnd);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, rayLength, friend_raymask))
        {

            Debug.Log(hitInfo.collider.gameObject.name);
            distance = Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position);
            hitText.text = distance.ToString();

            Debug.Log(hitInfo.distance.ToString());


            rayline.SetPosition(0, rayStart);
            rayline.SetPosition(1, hitInfo.collider.gameObject.transform.position);
        }
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo2, rayLength, enemy_raymask))
        {

            Debug.Log(hitInfo2.collider.gameObject.name);
            distance = Vector3.Distance(transform.position, hitInfo2.collider.gameObject.transform.position);
            hitText.text = distance.ToString();

            Debug.Log(hitInfo2.distance.ToString());


            rayline.SetPosition(0, rayStart);
            rayline.SetPosition(1, hitInfo2.collider.gameObject.transform.position);

            if(Input.GetKey(KeyCode.Space))
            {
                Destroy(hitInfo2.collider.gameObject);
            }
        }
    }
}

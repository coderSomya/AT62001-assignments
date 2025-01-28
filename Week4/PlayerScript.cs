using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(5000 * Time.deltaTime, 0, 0));

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, 2* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0,-2* Time.deltaTime);
        }
    }
}

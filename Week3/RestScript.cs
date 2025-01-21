using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestScript : MonoBehaviour
{
    float a = 0, b = 0.5f, c = 0;
    Vector3 restpos;
    // Start is called before the first frame update
    void Start()
    {
        restpos.x = a;
        restpos.y = b;
        restpos.z = c;
    }

    // Update is called once per frame
    void Update()
    {
     //   transform.position = restpos;
     //   transform.position += (restpos - transform.position).normalized * Time.deltaTime;
    }
}

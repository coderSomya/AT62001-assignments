using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript_7Jan_21ME10079 : MonoBehaviour
{
    // Start is called before the first frame update
    int startCounter = 0;
    int updateCounter = 0;
    void Start()
    {
        Debug.Log(startCounter);
        Debug.Log("inside start function");
        startCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateCounter);
        Debug.Log("inside update function");
        updateCounter++;

        Debug.Log("PRINTING DETAILS OF THE CUBE.....");
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);
    }
}
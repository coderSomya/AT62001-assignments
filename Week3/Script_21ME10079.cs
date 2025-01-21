using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_21ME10079 : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("game started...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED ENTER");
        sphere1.transform.localScale = Vector3.one;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("triggered stay");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          //  sphere2.transform.localScale-= new Vector3(0.2f,0.2f,0.2f);
        
            Debug.Log(sphere2.transform.localScale);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        //    sphere2.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            Debug.Log(sphere2.transform.localScale);

        }

    }
        private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("entered into collision");
        sphere1.transform.localScale = new Vector3(10, 10, 10);
      //  sphere1.transform.localScale = 10*Vector3.one;
        Debug.Log(sphere1.transform.localScale);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("exited into collision");
        sphere1.transform.localScale =  Vector3.one;
        Debug.Log(sphere1.transform.localScale);
    }
}

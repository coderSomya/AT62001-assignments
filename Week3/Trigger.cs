using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name); 
        Debug.Log("on trigger enter = "+collision.gameObject.name);
        transform.localScale = Vector3.one;
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("on trigger exit = "+ collision.gameObject.name);
        transform.localScale += Vector3.one;
    }

    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("on trigger stay = " + collision.gameObject.name);
        transform.localScale = Vector3.one;
    }
}

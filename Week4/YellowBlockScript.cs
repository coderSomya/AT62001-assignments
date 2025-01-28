using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlockScript : MonoBehaviour
{
    public PlayerScript _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        Debug.Log(other.gameObject.name);
        {
            if (other.gameObject.name == "Player")
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlockScript : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
            _playerScript.enabled = false;
    }
}
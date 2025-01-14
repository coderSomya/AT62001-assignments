using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager_script_21ME10079 : MonoBehaviour
{
    public GameObject chaser;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // logic for movement of the target 

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target.
         transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 10);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            target.
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 10);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            target.
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 10);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            target.
        transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * 10);
        }


        // look towards the target logic

        chaser.transform.forward = (target.transform.position - chaser.transform.position).normalized;
        

        // distance logic

        if((chaser.transform.position - target.transform.position).magnitude >=5)
        {
            
            chaser.transform.position += (target.transform.position - chaser.transform.position) - 5 * chaser.transform.forward;

            //methods that did not work

            //TODO: figure out whats wrong in each.
            
            // chaser.transform.Translate((chaser.transform.position - target.transform.position));
            // chaser.transform.Translate((target.transform.position - chaser.transform.position)*Time.deltaTime);
            // chaser.transform.position += new Vector3(1, 0, 0);
        }

    }
}
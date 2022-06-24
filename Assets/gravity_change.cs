using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity_change : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
     {
 
         if (Input.GetKeyDown(KeyCode.Space))
           
           gameObject.GetComponent<Rigidbody>().useGravity = true;
 
     }
}

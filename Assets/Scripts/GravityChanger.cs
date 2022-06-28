using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{

    bool gravity;
    Vector3 initPos;
    public GameObject playerCamera;
    Vector3 playerCameraInitPos;

    // Start is called before the first frame update
    void Start()
    {
        gravity = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        initPos = gameObject.transform.position;
        playerCameraInitPos = playerCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && gravity == false)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gravity = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && gravity == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gravity = false;
            
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gravity = false;

            this.transform.position = initPos;
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            playerCamera.transform.position = playerCameraInitPos;
        }
    }
}

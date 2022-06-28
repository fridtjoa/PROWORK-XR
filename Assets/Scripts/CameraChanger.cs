using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChanger : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;
    public CinemachineVirtualCamera BuilderCamera;
    public CinemachineVirtualCamera PlayerCamera;

    bool startPlay;

    // Start is called before the first frame update
    void Start()
    {
        startPlay = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C) && startPlay == false)

        {
            myAnimationController.SetBool("StartPlay", true);
            startPlay = true;
        }
        else if(Input.GetKeyDown(KeyCode.C) && startPlay == true)
        {
            myAnimationController.SetBool("StartPlay", false);
            startPlay = false;
        }



    }
}

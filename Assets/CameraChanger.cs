using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChanger : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;
    public CinemachineVirtualCamera BuilderCamera;
    public CinemachineVirtualCamera PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))

        {
            myAnimationController.SetBool("StartPlay", true);

        }

        if (Input.GetKeyDown(KeyCode.V))

        {
            myAnimationController.SetBool("StartPlay", false);

        }



    }
}

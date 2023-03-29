using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteract : MonoBehaviour
{
    public bool inDoorRange = false;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        inDoorRange = true;
    }
    public void OnTriggerExit(Collider other)
    {
        inDoorRange = false;
    }

    void Update()
    {
        if (inDoorRange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

            }
        }
    }
}

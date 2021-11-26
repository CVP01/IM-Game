using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions1 : MonoBehaviour
{
 
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Final Release will have a Functional Fuel System
        Debug.Log("Level Passed");
        Destroy(gameObject);
    }
}

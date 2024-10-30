using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

    
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that enterd the trigger is: " + other);
    }


  
}

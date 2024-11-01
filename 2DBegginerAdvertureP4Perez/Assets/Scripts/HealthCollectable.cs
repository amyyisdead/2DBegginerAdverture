using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

    
{

    void OnTriggerEnter2D(Collider2D other)
    {
        PLayerController controller = other.GetComponent<PLayerController>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
           
        }
    }


  
}

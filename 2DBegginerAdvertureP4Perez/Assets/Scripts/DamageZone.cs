using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
 void OnTriggerStay2D(Collider2D other)
    {
        PLayerController controller = other.GetComponent<PLayerController>();

        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}

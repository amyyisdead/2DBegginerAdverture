using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
 void OnTriggerStay2D(Collider2D other)
    {
        SugerlandController controller = other.GetComponent<SugerlandController>();

        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}

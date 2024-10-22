using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime; 

        transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COnt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical")

        Vector2 position = transform.position;
        position.y = 0.1f * vertical;
        position.x = 0.1f * horizontal;

        transform.position = position;
    }
}

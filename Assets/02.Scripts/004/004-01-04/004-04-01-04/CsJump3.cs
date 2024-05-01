using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump3 : MonoBehaviour
{
    float gravity = 0.0f;
    Vector3 vel;

    // Start is called before the first frame update
    void Start()
    {
        vel = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && vel.y == 0.5f)
        {
            gravity = 20.0f;
        }

        vel.y += gravity * Time.deltaTime;
        transform.position = vel;

        gravity -= 0.5f;

        if(vel.y < 0.5f)
        {
            vel.y = 0.5f;
            gravity = 0.0f;
        }
    }
}

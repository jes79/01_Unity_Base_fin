using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Jump == Space bar
        if (Input.GetButtonDown("Jump"))
        {

            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 10, 0);
        }
    }
}

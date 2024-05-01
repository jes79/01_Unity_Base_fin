using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump2 : MonoBehaviour
{

    Vector3 vel = new Vector3(0f, 400f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            GetComponent<Rigidbody>().AddForce(vel);
        }
    }
}

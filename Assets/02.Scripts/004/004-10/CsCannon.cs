using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCannon : MonoBehaviour
{
    float power = 1500.0f;
    Vector3 velocity = new Vector3(0.0f, 0.1f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        velocity = velocity * power;
        GetComponent<Rigidbody>().AddForce(velocity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.transform.position.z > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}

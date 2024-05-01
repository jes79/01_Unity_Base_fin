using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsThrow : MonoBehaviour
{

   public float power = 800.0f;
   public Vector3 velocity = new Vector3(0.5f, 0.5f, 0f);

    


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))   //Fire1 == MLC
        {
            
            GetComponent<Rigidbody>().AddForce(velocity*power);
        }
    }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCannonShot : MonoBehaviour
{
    //public Transform firePos;
    public GameObject cannon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
          
          //Instantiate(cannon, firePos.position, firePos.rotation);
            Instantiate(cannon, this.transform.position, this.transform.rotation);
        }
    }
}

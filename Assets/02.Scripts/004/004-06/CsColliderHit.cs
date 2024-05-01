using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsColliderHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.gameObject.tag == "Slope")
        {
            Debug.Log("Slope");
        }
    }
}

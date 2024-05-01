using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
}

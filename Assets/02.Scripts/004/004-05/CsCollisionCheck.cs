using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCollisionCheck : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsWhenDestroyPlay : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();

        Destroy(this.gameObject);
    }

}

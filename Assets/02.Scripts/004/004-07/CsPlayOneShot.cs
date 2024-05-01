using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPlayOneShot : MonoBehaviour
{
    //오디오 클립 타입의 변수 선언
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(clip, 0.8f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPlayClipAtPoint : MonoBehaviour
{

    float speed = 20.0f;

    public Transform cube1;
    public AudioClip myClip;



    // Update is called once per frame
    void Update()
    {
        //키보드 입력 
        float v = Input.GetAxis("Vertical");
        //이동거리 보정
        v = v * speed * Time.deltaTime;

        //실제 이동
        cube1.Translate(Vector3.forward * v);

        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource.PlayClipAtPoint(myClip, cube1.position);
        }
    }
}

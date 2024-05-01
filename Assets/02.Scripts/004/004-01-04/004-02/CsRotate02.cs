using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotate02 : MonoBehaviour
{
    float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 거리 보정
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Rotate(Vector3.forward * h);
        transform.Rotate(Vector3.right * v);
    }
}

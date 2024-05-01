using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsIdentity : MonoBehaviour
{
    public float rotSpeed = 120.0f;
    //
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //회전
        float amtRot = rotSpeed * Time.deltaTime;
        float ang = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * ang * amtRot);
        // a = 2, b = 2, a= a*b, a = 4 

        //float h = Input.GetAxis("Horizontal");
        //이동 거리 보정
        //h = h * rotSpeed * Time.deltaTime;
        //transform.Rotate(Vector3.forward * h);
        // a = 2 , a= a*2 , a = 4


        //정렬
        //월드 자표 또는 부모 축에 완벽히 정렬
        if (Input.GetButtonDown("Fire1"))
        {
            transform.localRotation = Quaternion.identity;
            //transform.rotation = Quaternion.identity;
        }
    }
}

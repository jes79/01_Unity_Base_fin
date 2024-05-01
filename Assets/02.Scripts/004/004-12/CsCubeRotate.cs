using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCubeRotate : MonoBehaviour
{
    //회전시간을 결정할 변수 선언
    float accTime = 0.0f;
    //회전을 결정할 bool 플래그 변수 선
    bool bRotate = false;

    // Update is called once per frame
    void Update()
    {
        //accTime이 1초보다 길어지면 회전을 멈추도록 bRotate 값을 false로 변경.(1초동안 회전시킨다)
        if ( accTime > 1.0)
        {
            bRotate = false;
        }

        //bRotate가 true 회전시킨다.
        if (bRotate)
        {
            accTime += Time.deltaTime;
            transform.Rotate(100.0f * Time.deltaTime * Vector3.up);
        }
    }

    public void RotateByHit()
    {
        accTime = 0.0f;
        bRotate = true;
    }
}

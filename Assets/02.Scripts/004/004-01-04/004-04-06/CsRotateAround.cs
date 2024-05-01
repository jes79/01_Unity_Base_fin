using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotateAround : MonoBehaviour
{
    Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Cube2").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //주변돌기 1
        //Vector3.zero를 기준으로 회전
        //파라미터 (회전 중심위치, 회전의 중심 축, 회전 속도)
        //transform.RotateAround(Vector3.zero, Vector3.up, 40 * Time.deltaTime);

        //주변돌기 2
        transform.RotateAround(obj.position, Vector3.up, 40 * Time.deltaTime);

        transform.LookAt(obj);

    }
}

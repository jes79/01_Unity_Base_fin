using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsLookAt : MonoBehaviour
{
    Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        //게임오브젝트 이름으로 찾기
        //코드에서 모든 컴퍼넌트는 소문자로 표현 대문자는 변수 타입
        obj = GameObject.Find("Cube2").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //주시
        transform.LookAt(obj);
    }
}

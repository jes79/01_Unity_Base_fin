using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotate01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 트랜스폼의 rotation 값 초기화 : 회전 #1
        //transform.eulerAngles = new Vector3(0.0f, 50.0f, 0.0f);

        // 트랜스폼의 rotation 값 : 회전 #2
        //rotation은 Quaternion 값으로 대입해 주어야 한다.
        //Quaternion target = Quaternion.Euler(0.0f, 100.0f, 0.0f);
        //transform.rotation = target;

        // transform.rotation = Quaternion.Euler(0.0f, 100.0f, 0.0f);


        //트랜스폼 중 회전 값을 현재 값에서 지정한 값만큼 회전(Rotate)시킨다.
        //transform.Rotate(Vector3.up * 60.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSmoothFollow : MonoBehaviour
{
    //따라갈 게임오브젝트(타켓)의 트랜스폼
    public Transform target;
    //타겟과의 거리를 결정할 변수
    public float distance = 15;
    //타겟과의 높이를 결정할 변수
    public float height = 5;
    //타겟을 따라갈때 부드럽게 처리할 변수
    public float heightDamping = 3;
    public float rotationDamping = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            //가려는 Transform
            float wantedRotationAngle = target.eulerAngles.y;
            float wantedHeight = target.position.y + height;
            //현재 Transform
            float currentRotationAngle = transform.eulerAngles.y;
            float currentHeight = transform.position.y;

            //부드러운 회전을 구현할 때 쓰는 함수 
            //Mathf.LerpAngle(flat a, float b, float t); -> (t시간(0~1) 동안 a부터 b까지 변경되는 각도를 반환함)
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

            //Mathf.Lerp(float a, float b, float t); -> (t시간(0~1) 동안 a 와 b를 보간)
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

            //오일러를 커터니언으로 변경
            Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            

            Vector3 pos = target.position;
            pos -= currentRotation * Vector3.forward * distance;
            pos.y = currentHeight;
            transform.position = pos;


            // 항상 타겟을 바라보게 하는 메서드
            transform.LookAt(target);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTankMove : MonoBehaviour
{
    //이동 스피드 값을 받을 변수
    public float moveSpeed;
    //회전 스피드 값을 받을 변수
    public float rotateSpeed;
    //게임오브젝트 터렛을 받을 변수
    public GameObject turret;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //이동 키보드 입력
        float v = Input.GetAxis("Vertical");
        //회전 키보드 입력
        float h = Input.GetAxis("Horizontal");

        //이동 거리 보정 
        v = v * moveSpeed * Time.deltaTime;
        //회전 값 보정
        h = h * rotateSpeed * Time.deltaTime;
       
        //만약 키보드의 버티컬 방향키가 눌리지 않았다면(전달 받은 값이 0과 같다면)
        //터렛을 회전
        //그렇지 않다면 Tank 이동, 회전
        if(Input.GetAxis("Vertical") == 0)
        {
           turret.transform.Rotate(Vector3.up * h);
        }
        else
        {
            //실제이동 
            transform.Translate(Vector3.forward * v);
            //실제회전
            transform.Rotate(Vector3.up * h);
        }

    }
}

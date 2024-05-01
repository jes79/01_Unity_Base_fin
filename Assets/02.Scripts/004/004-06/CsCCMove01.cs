using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCCMove01 : MonoBehaviour
{
    float moveSpeed = 20.0f;
    float rotateSpeed = 50.0f;
    CharacterController cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = GetComponent<CharacterController>();
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

        //실제이동 
        cont.Move(Vector3.forward * v);

        //실제회전
        transform.Rotate(Vector3.up * h);

    }
}
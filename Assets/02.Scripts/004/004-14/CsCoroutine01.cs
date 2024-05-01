using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCoroutine01 : MonoBehaviour
{
   
    void Update()
    {
        //마우스 좌클릭 감지
        if (Input.GetButtonDown("Fire1"))
        {
            //코루틴 메서드를 호출
            StartCoroutine("Exam1");
        }
    }

    //코루틴 메서드의 반환형 IEnumerator
    IEnumerator Exam1()
    {
        //이번 프레임이 끝난 후 실행
        yield return new WaitForEndOfFrame();
        //실행하고자 하는 함수
        FirstCall();
        //지정한 시간(2.0f 초)이 지난 후 실행
        yield return new WaitForSeconds(2.0f);
        //실행하고자 하는 함수
        SecondCall();
    }

    //함수
    void FirstCall()
    {
        Debug.Log("First");

    }
    //함수
    void SecondCall()
    {
        Debug.Log("Second");
    }
}

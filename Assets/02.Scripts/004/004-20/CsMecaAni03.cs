using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI 추가

public class CsMecaAni03 : MonoBehaviour
{
    //애니메이터 타입 변수 선언
    Animator anim;
    
    // 버튼 타입 변수 선언
    public Button btn1, btn2, btn3;

    // Start is called before the first frame update
    void Start()
    {
        // 변수에 애니메이터컴퍼넌트 대입
        anim = GetComponent<Animator>();
    
        //버튼을 클릭 시 메서드 호출 
        btn1.onClick.AddListener(Idle);
        btn2.onClick.AddListener(Walk);
        btn3.onClick.AddListener(Jump);
    }

    
   public void Idle()
    {
        //aniStep 변수에 인트타입의 값 0을 대입
        anim.SetInteger("aniStep", 0);
        
    }

    public void Walk()
    {
        //aniStep 변수에 인트타입의 값 1을 대입
        anim.SetInteger("aniStep", 1);

    }

    public void Jump()
    {
        StartCoroutine(coJump());
    }

    IEnumerator coJump()
    {
        //aniStep 변수에 인트타입의 값 2을 대입
        anim.SetInteger("aniStep", 2);
        //0.8초 후  aniStep 변수에 인트타입의 값 0을 대입
        yield return new WaitForSeconds(0.8f);
        anim.SetInteger("aniStep", 0);
    }

   
}

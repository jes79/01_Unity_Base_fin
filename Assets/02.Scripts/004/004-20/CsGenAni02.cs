using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI 추가

public class CsGenAni02 : MonoBehaviour
{
    //애니메이터 탑입 변수 선언
    Animator anim;
    
    public Button btn1, btn2, btn3;

    // Start is called before the first frame update
    void Start()
    {
        // 변수에 애니메이터컴퍼넌트 대입
        anim = GetComponent<Animator>();
    
        //버튼을 클릭 시 메서드 호출 
        btn1.onClick.AddListener(FoxSit);
        btn2.onClick.AddListener(FoxJump);
        btn3.onClick.AddListener(FoxWalk);
    }

    
   public void FoxSit()
    {
        //aniStep 변수에 인트타입의 값 1을 대입
        anim.SetInteger("aniStep", 1);
        
    }

    public void FoxJump()
    {
        //aniStep 변수에 인트타입의 값 2을 대입
        //anim.SetInteger("aniStep", 2);

        //IEnumeratero coJump 호출
        StartCoroutine("coJump");
    }

    
    IEnumerator coJump()
    {
        //aniStep 변수에 인트타입의 값 2을 대입
        anim.SetInteger("aniStep", 2);
        //0.8초 후  aniStep 변수에 인트타입의 값 0을 대입
        yield return new WaitForSeconds(0.8f);
        anim.SetInteger("aniStep", 0);
    }

    public void FoxWalk()
    {
        //aniStep 변수에 인트타입의 값 3을 대입
        anim.SetInteger("aniStep", 3);
    }

}

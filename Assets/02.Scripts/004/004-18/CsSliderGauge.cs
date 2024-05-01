using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Silder class 사용하기 위해 추가합니다.

public class CsSliderGauge : MonoBehaviour
{
   // 슬라이더 타입의 변수를 선언
    Slider slGauge;
    // 트렌스폼 타입의 변수를 선언
    Transform trs;

    void Start()
    {
        //시작할때 이 스크립트 컴포넌트가 적용된 게임오브젝트의 슬라이더 컴포넌트를 변수에 대입
        slGauge = GetComponent<Slider>();
        ////시작할때 이 스크립트 컴포넌트가 적용된 게임오브젝트의 자식인 (Fill Area)를 찾아서 변수에 대입
        trs = transform.Find("Fill Area");
    }


    void Update()
    { //이 스크립트 컴포넌트가 적용된 슬라이더의 vaule 값이 0이하면 비활성화 그렇지 않으면 활성화
        if (slGauge.value <= 0)
            trs.gameObject.SetActive(false);
        else
            trs.gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//추가

public class CsSlider : MonoBehaviour
{
    //텍스트 타입 변수 선언
    Text txt;
    Text lbl;

    //슬라이더 타입 변수 선언
    Slider slider1;
    Slider slider2;
    //폰트 사이즈로 사용할 int 타입 변수 선언
    int fontSiz;

    // Start is called before the first frame update
    void Start()
    {
        //시작할 때 txtCenter게임오브젝트의 Text컴포넌트를 가져온다.
        txt = GameObject.Find("txtCenter").GetComponent<Text>();

        //시작할 때 게임오브젝트 Slider1,2의 Slider컴포넌트를 가져온다.
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();

        //자식 오브젝트를 찾아 컴포넌트를 가져온다.
        //lbl = slider1.transform.GetChild(3).GetComponent<Text>();
        lbl = slider1.transform.Find("Label Percent").GetComponent<Text>();

        //fontSize 변수에 현재 txtCenter게임오브젝트의 fontSize를 대입한다. 
        fontSiz = txt.fontSize;

        //slider2에 이벤트 리스너를 설정해 함수를 호출
        slider2.onValueChanged.AddListener(ChangeSliderValue);
    }


    public void ChangeSliderValue(float value)
    {
        //Slider2의 value(float 타입) 값을 val에 대입
        float val = slider2.value;

        //val을 slider1의 value 값에 대입
        slider1.value = val;

        //txtCenter게임오브젝트의 Text의 fontSize에 현재 폰트사이즈(int)에 
        //slider2의 value값을 인트로 변경을 더한 후 대입
        txt.fontSize = fontSiz + (int)val;

        if (lbl != null)
        {
            //lbl.text = (int)val * 10 + "%";
            //lbl.text = val*10 + "%";
            lbl.text = Mathf.RoundToInt(value * 10) + "%";

        }

    }
}
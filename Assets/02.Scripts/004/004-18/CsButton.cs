using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsButton : MonoBehaviour
{
    //게임오브젝트 타입의 변수 선언
    GameObject obj;
    //텍스트 타입의 변수 선언
    Text txt;
    //버튼 탑입의 변수 선언
    Button btn;
    
    //부울 타입의 변수를 선언
    bool b1;

    void Start()
    {
        //게임오브젝트 "txtCenter"를 찾아서 obj에 대입
        obj = GameObject.Find("txtCenter");
        // obj에서 Text 컴포넌트를 txt에 대입
        txt = obj.GetComponent<Text>();

        //게임오브젝트 "Button" 찾고 Button 컴포넌트를 btn에 대입
        btn = GameObject.Find("Button").GetComponent<Button>();
        
        //버튼을 크릭시 메서드 호출
        btn.onClick.AddListener(ChangeText);
    }



    void ChangeText()
    {
        
        if (b1)
        {
            //txtCenter 게임오브젝트의 Text컴포넌의 text 값을 "GoodBye World"로 설정
            txt.text = "GoodBye World";
            
            // 부울타입 b1에 false 대입
            b1 = false;
        }
        else
        {
            txt.text = "Hello World";
            // 부울타입 b1에 true 대입
            b1 = true;
        }
        

    }


}

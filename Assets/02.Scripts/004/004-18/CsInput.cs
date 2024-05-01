using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //추가


public class CsInput : MonoBehaviour
{
    //변수 선언
    //텍스트 타입
    Text txt;
    //인풋필드 타입
    InputField input1;
    InputField input2;
    InputField input3;
    //버튼 타입
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        //시작할때 변수에 "게임오브젝트명"으로 게임오브젝트를 찾아서 < > 컴포넌트를 찾아 대입
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        input1 = GameObject.Find("InputField1").GetComponent<InputField>();
        input2 = GameObject.Find("InputField2").GetComponent<InputField>();
        input3 = GameObject.Find("InputArea").GetComponent<InputField>();
        
        btn = GameObject.Find("Button").GetComponent<Button>();

        //버튼 클릭 시 onClick 이벤트로 메서드 호출
        btn.onClick.AddListener(ChangeValue);
    }

    public void ChangeValue()
    {
        //"txtCenter"의 text에 "InputField1"에 입력한 텍스트를 대입
        txt.text = input1.text;


        Debug.Log("InputField1 : " + input1.text);
        Debug.Log("InputField2 : " + input2.text);
        Debug.Log("InputArea : " + input3.text);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CsToggle2 : MonoBehaviour
{
    //게임오브젝트 타입의 변수 선언
    GameObject obj;
    //텍스트 타입의 변수 선언
    Text txt;
    //토글 타입의 변수 선언
    Toggle tgChangeText;


    // Start is called before the first frame update
    void Start()
    {
        //게임오브젝트 "txtCenter"를 찾아서 obj에 대입
        obj = GameObject.Find("txtCenter");
        // obj에서 Text 컴포넌트를 txt에 대입
        txt = obj.GetComponent<Text>();

        //게임오브젝트 "Toggle"를 찾아서 Toggle 커포넌트를 대입
        tgChangeText = GameObject.Find("Toggle").GetComponent<Toggle>();


        //tgChangeText.onValueChanged.AddListener(ChangeText);

    }


    public void ChangeText(bool _bool)
    {
        if (tgChangeText.isOn)
        {
            //토글 체그가 되어있으면 txtCenter 게임오브젝트의 Text컴포넌의 text 값을 "Hello World"로 설정
            txt.text = "Hello World";
        }
        else
        {
            txt.text = "GoodBye World";
        }


    }
}

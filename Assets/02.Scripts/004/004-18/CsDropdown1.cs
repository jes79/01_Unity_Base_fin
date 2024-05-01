using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //추가

public class CsDropdown1 : MonoBehaviour
{
    //변수 선언
    //옵션을 선택할 시 변경될 테스트의 텍스트 타입 변수
    public Text txtCenter;

    //Dropdown 타입 변수
    public Dropdown dropdown;
 

    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate {
            Function_Dropdown(dropdown);
        });
    }

    private void Function_Dropdown(Dropdown select)
    {
        string op = select.options[select.value].text;
        txtCenter.text = op;

    }

}

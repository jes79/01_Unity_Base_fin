using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //추가

public class CsDropdown2 : MonoBehaviour
{
    //변수 선언
    
    //옵션을 선택할 시 변경될 테스트의 텍스트 타입 변수
    public Text txtCenter;
    //Dropdown의 Sprite가 노출될 이미지 타입 변수
    public Image iconImg;
    //Dropdown 타입 변수
    public Dropdown dropdown;
    //Dropdown의 Sprite에 삽입할 스트라이트 배열 타입 변수
    public Sprite[] sprite;
    //Dropdown의 text에 삽이될 String을 초기화
    public string[] txtChange = new string[] { "A", "B", "C", "D" };
    //버튼타입 변수
    public Button btnIcon;



    void Start()
    {
        SetFunction_UI();
    }

    
    private void SetFunction_UI()
    {
        
        ResetFunction_UI();

        btnIcon.onClick.AddListener(Function_Button);
        dropdown.onValueChanged.AddListener(delegate {
            Function_Dropdown(dropdown);
        });
    }

    private void Function_Button()
    {
        //string op = dropdown.options[dropdown.value].text;
       
        iconImg.sprite = dropdown.options[dropdown.value].image;
       
    }

    private void Function_Dropdown(Dropdown select)
    {
        string op = select.options[select.value].text;
        txtCenter.text = op;
       
    }

    private void ResetFunction_UI()
    {
        btnIcon.onClick.RemoveAllListeners();
        dropdown.onValueChanged.RemoveAllListeners();
        dropdown.options.Clear();

        for (int i = 0; i < txtChange.Length; i++)
        {
            Dropdown.OptionData newData = new Dropdown.OptionData();
            newData.text = txtChange[i];
            newData.image = sprite[i];
            dropdown.options.Add(newData);
        }
        dropdown.SetValueWithoutNotify(-1);
        dropdown.SetValueWithoutNotify(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //추가

public class CsGameMgrPP : MonoBehaviour
{
    //인풋필드를 받는 변수
    public InputField inputID;
    public InputField inputPass;

    
    public void Save()
    {
        //"ID" 키로 설정된 String 타입 값을 설정
        PlayerPrefs.SetString("ID", inputID.text);
        //"Pass" 키로 설정된 int 타입 값을 설정
        //텍스트(String 타입)으로 입력받기 때문에 int 타입으로 변환 필요[int.Pasrse(String)]
        PlayerPrefs.SetInt("Pass", int.Parse(inputPass.text));
    }

    public void Load()
    {
        //"ID" 키가 존재한다면
        if (PlayerPrefs.HasKey("ID"))
        {
            //"ID"키의 스티링 타입 값을 인풋필드의 텍스트에 반환
            inputID.text = PlayerPrefs.GetString("ID");
            //"Pass"키의 Int 타입 값을 인풋필드의 텍스트에 반환
            // int 타입이기 때문에 스트링 타입으로 변환 필요 [(int).ToString();
            inputPass.text = PlayerPrefs.GetInt("Pass").ToString();
        }
    }
  
}

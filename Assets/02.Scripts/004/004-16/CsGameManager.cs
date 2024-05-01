using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //추가

public class CsGameManager : MonoBehaviour
{
    public Button btn1, btn2, btn3;

    GameObject obj;
    

    void Start()
    {
        obj = GameObject.Find("Cube");

        btn1.onClick.AddListener(MethodCall1);
        btn2.onClick.AddListener(MethodCall2);
        btn3.onClick.AddListener(MethodCall3);
    }
 
    //메서드 호출 방법 1 : 특정 Object 안에 있는 Script 메서드 호출
    //private Method 호출 불가
    public void MethodCall1()
    {
        CsRotateCube script = obj.GetComponent<CsRotateCube>();
        //public Method
        script.Rotate1();
        Debug.Log("메서드 호출 방법 1로 Rotate1 메서드 호출");
        //private Method 호출 불가
        //script.Rotate2();
        
    }

    //메서드 호출 방법 2 : 게임오브젝트에 메시지를 보내서 메서드를 호출하는 방법
    //private Method 호출할 때 사용
    public void MethodCall2()
    {
        CsRotateCube script = obj.GetComponent<CsRotateCube>();
        //public Method 호출 가능
        //obj.SendMessage("Rotate1", SendMessageOptions.DontRequireReceiver);
        //Debug.Log("메서드 호출 방법 2로 Rotate1 메서드 호출");
        
        //private Method 호출 가능
        obj.SendMessage("Rotate2", SendMessageOptions.DontRequireReceiver);
        Debug.Log("메서드 호출 방법 2로 Rotate1 메서드 호출");
    }

    //메서드 호출 방법 3 : 게임오브젝트를 변수로 가져오지 않고도 바로 메서드 호출 가능
    //스택틱 변수, 메서드만 가능
    public void MethodCall3()
    {
        Debug.Log("스테틱 변수 호출 : " + CsRotateCube.numX);

        Debug.Log("스테틱 함수 호출 : " + CsRotateCube.AddTwoNum(3, 5));
    }

}

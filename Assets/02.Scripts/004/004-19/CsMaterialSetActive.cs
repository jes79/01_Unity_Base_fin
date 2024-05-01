using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMaterialSetActive : MonoBehaviour
{
    public GameObject boots;
    
    public GameObject pants;
    
    public GameObject shirt;
    
    public GameObject helmet;

    // Start is called before the first frame update
    void Start()
    {
        //(02)모델을 비활성화 시키는 메서드 호출
        SetActiveOff();
    }


    // (02)모델을 비활성화 시키는 메서드
    void SetActiveOff()
    {
        boots.gameObject.SetActive(false);
        pants.gameObject.SetActive(false);
        shirt.gameObject.SetActive(false);
        helmet.gameObject.SetActive(false);
    }
}

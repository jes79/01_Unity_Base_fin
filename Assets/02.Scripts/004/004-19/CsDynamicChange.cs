using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsDynamicChange : MonoBehaviour
{
    //Main Camera(게임오브젝트)를 담을 변수
    //GameObject obj;

    CsMaterialSet01 csMat;

    public Button[] btn;

    int nKind = 0;

    bool bModel = false;

    // Start is called before the first frame update
    void Start()
    {
        //게임오브젝트를 이름으로 찾아 obj 담는다.
        //obj = GameObject.Find("Main Camera");
        //메인카메라의 CsMaterialSet01 스크립트 컴퍼넌트에 접근
        csMat = Camera.main.GetComponent<CsMaterialSet01>();

        //게임 실행 시 겹치지 않도록 2종의 오브젝트 중 하나(02)를 비활성화
        csMat.helmet02.SetActive(bModel);
        csMat.shirt02.SetActive(bModel);
        csMat.pants02.SetActive(bModel);
        csMat.boots02.SetActive(bModel);

        //메서드 호출
        btn[0].onClick.AddListener(ChangeHelmet01);
        btn[1].onClick.AddListener(ChangeHelmet02);

        btn[2].onClick.AddListener(ChangeShirt01);
        btn[3].onClick.AddListener(ChangeShirt02);

        btn[4].onClick.AddListener(ChangePants01);
        btn[5].onClick.AddListener(ChangePants02);

        btn[6].onClick.AddListener(ChangeBoots01);
        btn[7].onClick.AddListener(ChangeBoots02);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 모델의 메터리얼을 변경하는 메서드
    public void ChangeHelmet01()
    {
        // 02모델 오프
        csMat.helmet02.SetActive(false);
        // 01모델 온
        csMat.helmet01.SetActive(true);
        
        //후치 증가
        nKind++;

        //만약 헬멧 메터리얼 배열 크기에 -1한 값보다 nKind가 크면 실행
        if (nKind > csMat.helmet.Length - 1)
        {
            //nKind에 0을 대입
            nKind = 0;
        }

        //메서드에 접근할 수 있도록 CsMaterialSet 메서드를 pulic으로 변경
        csMat.CharMaterialSet(csMat.helmet01, csMat.helmet[nKind]);
    }

    public void ChangeHelmet02()
    {
        csMat.helmet01.SetActive(false);
        csMat.helmet02.SetActive(true);
        nKind++;

        if (nKind > csMat.helmet.Length - 1)
        {
            nKind = 0;
        }

        csMat.CharMaterialSet(csMat.helmet02, csMat.helmet[nKind]);
    }

    public void ChangeShirt01()
    {
        csMat.shirt02.SetActive(false);
        csMat.shirt01.SetActive(true);
        nKind++;

        if (nKind > csMat.shirt.Length - 1)
        {
            nKind = 0;
        }
 
        csMat.CharMaterialSet(csMat.shirt01, csMat.shirt[nKind]);
    }

    public void ChangeShirt02()
    {
        csMat.shirt01.SetActive(false);
        csMat.shirt02.SetActive(true);
        nKind++;

        if (nKind > csMat.shirt.Length - 1)
        {
            nKind = 0;
        }

        csMat.CharMaterialSet(csMat.shirt02, csMat.shirt[nKind]);
    }

    public void ChangePants01()
    {
        csMat.pants02.SetActive(false);
        csMat.pants01.SetActive(true);
        nKind++;

        if (nKind > csMat.pants.Length - 1)
        {
            nKind = 0;
        }
     
        csMat.CharMaterialSet(csMat.pants01, csMat.pants[nKind]);
    }

    public void ChangePants02()
    {
        csMat.pants01.SetActive(false);
        csMat.pants02.SetActive(true);
        nKind++;

        if (nKind > csMat.pants.Length - 1)
        {
            nKind = 0;
        }
       
        csMat.CharMaterialSet(csMat.pants02, csMat.pants[nKind]);
    }

    public void ChangeBoots01()
    {
        csMat.boots02.SetActive(false);
        csMat.boots01.SetActive(true);
        nKind++;

        if (nKind > csMat.boots.Length - 1)
        {
            nKind = 0;
        }

        csMat.CharMaterialSet(csMat.boots01, csMat.boots[nKind]);
    }

    public void ChangeBoots02()
    {
        csMat.boots01.SetActive(false);
        csMat.boots02.SetActive(true);
        nKind++;

        if (nKind > csMat.boots.Length - 1)
        {
            nKind = 0;
        }

        csMat.CharMaterialSet(csMat.boots02, csMat.boots[nKind]);
    }

}

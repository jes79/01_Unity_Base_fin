using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Ui 항목에 접근하기 위해 필요

public class Basket : MonoBehaviour
{

    GameObject obj;

    //UI Text 커퍼넌트 변수(New Text)
    private Text txtScore;

    //누적 점수를 기록하기 위한 변수
    private int totScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Text 오브젝트를 찾아 Text 컴퍼넌트에 접근
        obj = GameObject.Find("Text");
        txtScore = obj.GetComponent<Text>();

        // 게임 0점(인수)으로 시작
        DispScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        // Input에서 마우스의 현재 화면 위치를 얻음
        Vector3 mousePos2D = Input.mousePosition;

        // 카메라의 z 위치만큼 3D 공간에 마우스를 앞으로 전진
        // 이 게임에서 메인카메라의 z위치는 -10이므로 mousePos2D.z는 10으로 설정된다.
        // 이 값은 이후 호출할 ScreenToWorldPoint함수에 mousePos3D가 3D공간에서 얼마나 전진하는 알려준다.
        mousePos2D.z = -Camera.main.transform.position.z;

        // 2D 화면 공간의 지점을 3D 게임 세계 공간으로 변환
        // 메인카메라 z위치 (-10)에서 10전진해서 mousePos3D.z가 0이 되록했다.
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // 마우스의 x위치로 이 바구니의 x위치를 설정
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }

    //Basket에 Apple이 충돌하면 충돌한 Apple 삭제
    private void OnCollisionEnter(Collision coll)
    {
        //이 바구니가 무엇과 충돌했는지 확인
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }


        DispScore(100);
    }


    public void DispScore(int score)
    {
        //누적 점수를 기록하기 위한 변수에 인자(score)를 더해서 대입 
        totScore += score;
        //txtScore.text(int)를 문자열(string)으로 변환해 적용
        txtScore.text = totScore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsScreenPointMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        //마우스 좌 클릭을 감지
        if (Input.GetButton("Fire1"))
        {
            //메인 카메라에서 월드 안으로 마우스 클릭한 지점까지 레이 정보를 만든다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이캐스트의 충돌체 정보를 저장할 변수를 선언
            RaycastHit hit;

            // (ray)로 구한 레이 정보로 레이캐스팅을 한다
            if(Physics.Raycast(ray, out hit))
            {
                //마우스로 클릭한 지점을 벡터3으로 만든다.
                //y축이 Plane에 파묻히지 않게 이 스크립트가 적용되는 게임오브젝트의 포지션의 y축으로 적용
                Vector3 newPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                
                //생로운 벡터값의 위치로 이동
                transform.position = newPos;
            }
        } 
    }
}

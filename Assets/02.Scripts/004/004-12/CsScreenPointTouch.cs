using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsScreenPointTouch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //마우스 좌클릭 감지
        if (Input.GetButtonDown("Fire1"))
        {
            //마우스 좌클릭한 지점의 레이 정보를 만든다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이캐스트의 충돌체 정보를 저장할 변수를 선언
            RaycastHit hit;

            //레이캐스팅을 이요해 충돌체를 찾는다.
            if(Physics.Raycast(ray, out hit))
            {
                //충돌체의 테크 정보가 Enemy 인지 확인
                if (hit.transform.tag.Equals("Enemy"))
                {
                    //퍼블릭의로 선언된 외부 게임 오브젝트의 스크립트 컴포넌트에 대한 변수를 선언하고 값을 연결
                    CsCubeRotate cubeScript = hit.transform.GetComponent<CsCubeRotate>();
                    //스크리트 컴포넌트가 null이 아니라면 RotateByHit()메서드 호출
                    if(cubeScript != null)
                    {
                        cubeScript.RotateByHit();
                    }
                        
                }
            }
        }

    }
}

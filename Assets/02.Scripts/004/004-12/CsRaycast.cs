using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRaycast : MonoBehaviour
{
    private float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //이동
        float amtMove = speed * Time.deltaTime;
        float hor = Input.GetAxis("Horizontal");
        //게임오브젝트 좌우로 이동
        transform.Translate(Vector3.right * hor * amtMove);

        //DrawRay
        //레이케스트가 보이게 설정
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        //레이케스트 결과값을 저장할 변수를 선언
        RaycastHit hit;
        //광선을 쏴서 충돌한 게임 오브젝트를 앞서 선언한 변수 hit에 저장
        if(Physics.Raycast(transform.position, transform.forward, out hit, 8))
        {
            //광선이 충돌한 게임 오브젝트의 이름을 콘솔 창에 출력
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}

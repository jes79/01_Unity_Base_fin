using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsLookEnemy : MonoBehaviour
{
    //Enemy의 트랜스폼 정보를 저장할 변수를 선언
    public Transform enemy;
    //스폰포인트의 트랜스폼 정보를 저장할 변수를 선언
    private Transform spPoint;
    
    
    //레이캐스트의 충돌체 정보를 저장할 변수를 선언
    RaycastHit hit;
    Vector3 fwd = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        //지정한 자식 객체(게임오브젝트)를 찾아 트랜스폼 정보를 변수에 적용
        spPoint = transform.Find("/Turret/Tower/SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        //enemy를 바라보 enemy의 움직임을 따라 회전
        transform.LookAt(enemy);
        //스폰포인트의 정면방향(forward)으로 4 유닛 거리만큼 빨간색으로 레이캐스트를 표시
        Debug.DrawRay(spPoint.position, spPoint.forward * 4, Color.red);

        //레이케스트를 발사해 충돌체를 찾아온다면
        if (Physics.Raycast(spPoint.position, fwd, out hit, 4))
        {
            //충돌체의 정보를 가져와서 콘솔창에 게임오브젝트의 이름을 출력한다.
            Debug.Log(hit.collider.gameObject.name);
        }

    }
}

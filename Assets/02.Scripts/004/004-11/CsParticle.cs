using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsParticle : MonoBehaviour
{
    //SpawnPoint 게임오브젝트의 위치값을 가져올 변수
    public Transform spawnPoint;
    //게임오브젝트로 만들 프리팹을 지정할 변수
    public GameObject myParticle;

    // Update is called once per frame
    void Update()
    {
        //마우스 좌클릭 감지
        if (Input.GetButtonDown("Fire1"))
        {
            //메서드 실행
            DoMyParticle();
        }
    }

    void DoMyParticle()
    {
        // 게임오브젝트 변수에 파티클시스템 게임오브젝트 생성해서 대입 
        GameObject particleObj = Instantiate(myParticle);
        // 생성된 파티클시스템 게임오브젝트의 위치
        particleObj.transform.position = spawnPoint.position;
        // 1초후 생성된 파티클 시스템 게임오브젝트 제거
        Destroy(particleObj, 1.0f);
    }
}

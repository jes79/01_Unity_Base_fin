using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject WallPrefab;
    public float interval;
    //스포너 y축 랜덤 위치를 위한 실수
    public float range = 3.0f;

    // //이뉴머레이트는 차후 유니티 핵심 기술 코루틴 시간에 상세 설명
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);
            Instantiate(WallPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

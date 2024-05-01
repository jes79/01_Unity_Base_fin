using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    //Apple을 인스터스화 하기 위한 프리팹
    public GameObject applePrefab;

    //AppleTree가 움직이는  속도(m/s)
    public float speed = 1f;

    //AppleTree가 움직일 수 이쓴 좌우 거리
    public float leftAndRightEdge = 10f;

    //AppleTree가 방향을 바꾸는 확률
    public float chanceToChangeDirections = 0.1f;

    //Apple이 인스턴스화되는 속도
    public float SecondsBetweenAppleDrops = 1f; 
    
    // Start is called before the first frame update
    void Start()
    {
        // 사과를 1 초마다 하나씩 떨어뜨림
        InvokeRepeating("DropApple", 2f, SecondsBetweenAppleDrops);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        // 떨어질 사과의 위치는 애플프리 위치
        apple.transform.position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        // 기본적인 이동
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // 방향 바꾸기
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //오른쪽으로 이동
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //왼쪽으로 이동
        }
    }

    // 컴퓨터 속도에 관계없이 초당 50회 호출
    private void FixedUpdate()
    {
        //임의로 방향 바꾸기
        // Random.value : 0.0[포함]에서 1.0[포함] 사이의 임의의 수를 반환
        if (Random.value < chanceToChangeDirections)
        {
            speed += -1; // 방향 바꾸기
        }
    }
}

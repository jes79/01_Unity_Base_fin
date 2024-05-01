using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsDistance : MonoBehaviour
{
    //거리를 구하기 위한 게임오브젝트의 트랜스폼을 저장할 변수
    public Transform box1;
    public Transform box2;
    public Transform box3;

    // Start is called before the first frame update
    void Start()
    {
        //두 Object 사이의 거리 구하기 1
        float distance1 = Vector3.Distance(transform.position, box2.position);
        Debug.Log("distance1 : " + distance1);

        //두 Object 사이의 거리 구하기 2
        //타겟이 항상 앞에 나와야 한다.
        float distance2 = (box3.position - transform.position).magnitude;
        Debug.Log("distance2 : " + distance2);

        //방향 구하기 
        //방향은 거리가 필용 없기 때문에 방향을 구하기 위한 벡터를 구해서 [단위화(Normalize)] 한다.
        Vector3 dir = box2.position - transform.position;
        dir.Normalize();

        // 회전 
        transform.eulerAngles = dir;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 360; i++)
        {
            if (i % 90 != 0)
            {             // i/90의 나머지가 0이 아니면 실행
                continue; // 반복을 생략하고 조건으로 이동
            }
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

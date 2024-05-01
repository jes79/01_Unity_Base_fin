using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 3)
        {
            print(" Loop :" + i);
        
          i++ ; // 증가 연산자 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

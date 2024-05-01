using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodVar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Say("Hello");       
    }

    void Say ( string sayThis)    //sayThis가 Say()의 매개 변수
    {
        print(sayThis);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

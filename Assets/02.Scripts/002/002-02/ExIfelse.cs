using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExIfelse : MonoBehaviour
{
    public int data = 85;
    // Start is called before the first frame update
    void Start()
    {
        
        if(data >= 90)
        {
            Debug.Log("수");
        }else if(data >=80)
        {
            Debug.Log("우");
        }else if (data >= 70)
        {
            Debug.Log("미");
        }else if (data >= 60)
        {
            Debug.Log("양");
        }else{
            Debug.Log("가");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolWhile : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int i = 1;
        int sum = 0;
        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                sum += i;               
            }
            i++;
        }

        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

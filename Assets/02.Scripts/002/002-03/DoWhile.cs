using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 10;
        do
        {
            print(" Loop: " + i);
            i++;
        } while (i < 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

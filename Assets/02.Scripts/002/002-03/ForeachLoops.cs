using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "Hello";
        foreach (char chr in str)
        {
            print(chr);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

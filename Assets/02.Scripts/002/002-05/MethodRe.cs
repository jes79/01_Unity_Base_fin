using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodRe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = Add(2, 5) ;
        print(num);

    }

    int Add (int numA, int numB)
    {
        int sum = numA + numB;
        return (sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = Add(2, 5);
        print(num);

        print(Add(1.5f, 3.1f));

    }

    int Add(int numA, int numB)
    {
        int sum = numA + numB;
        return (sum);
    }

    float Add(float numA, float numB)
    {
        return (numA + numB);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExBook : MonoBehaviour
{
    public int price = 1;
    public int num = 2;
    

    // Start is called before the first frame update
    void Start()
    {
      print(Sum(price, num));
    }

    int Sum(int a, int b)
    {
        return (a * b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

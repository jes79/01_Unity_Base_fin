using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = { 1, 2, 3, 4 };

        foreach (int a in nums)
            print(a);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitNum : MonoBehaviour
{
    int num = 4;

    // Start is called before the first frame update
    void Start()
    {
        switch (num)
        {
            case (0):
                print("숫자는 0이다.");
                break;
            case (1):
                print("숫자는 1이다.");
                break;
            case (2):
                print("숫자는 2이다.");
                break;
            case (3):
            case (4):
            case (5):
                print("숫자는 3~5이다.");
                break;

            default:
                print("숫자는 6 이상이다.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

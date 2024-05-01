using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightIf : MonoBehaviour
{
    bool night = true;
    bool fullMoon = false;

    // Start is called before the first frame update
    void Start()
    {
        if (night)
        {
            print(" 지금은 밤이다.");
        }

        if (!fullMoon)
        {
            print(" 보름달은 아니다. ");
        }

        if (night && fullMoon)
        {
            print(" 늑대 인간을 조심하자!!!");
        }

        if (night && !fullMoon)
        {
            print(" 오늘은 늑대 인간이 안 나온다. (휴우!)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

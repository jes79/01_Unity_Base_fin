using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightIfE : MonoBehaviour
{
    bool night = true;
    bool fullMoon = true;

    // Start is called before the first frame update
    void Start()
    {
        if (!night)
        {
            print("지금은 낮이다. 걱정하지 안아도 된다.");
        }
        else if (fullMoon)
        {
            print("늑대 인간을 조심하자!!!");
        }
        else
        {
            print("지금은 밤이지만, 보름달은 아니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (!night)
        {                                    
            print("지금은 낮이다. 걱정하지 안아도 된다.");
        }
        else if (fullMoon)
        {                            
            print("늑대 인간을 조심하자!!!");
        }
        else
        {                                          
            print("지금은 밤이지만, 보름달은 아니다.");
        }
        */
    }
}

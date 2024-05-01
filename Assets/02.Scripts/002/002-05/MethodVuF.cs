using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodVuF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0;i<2; i++ )
        {
            Shooting();
        }
    }
    void Shooting()
    {
        print("Reload Bullet");  //장전
        print("Take Aim");       //조준
        print("Shoot");          //격발
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

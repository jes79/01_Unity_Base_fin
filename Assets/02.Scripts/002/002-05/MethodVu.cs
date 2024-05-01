using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodVu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shooting();
        Shooting();
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

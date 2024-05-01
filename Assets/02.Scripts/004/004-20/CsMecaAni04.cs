using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMecaAni04 : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //시작할 때 게임 오브젝트의 애니메이터 컨트롤러를 가져온다
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //
        anim.SetFloat("speed", v);
        anim.SetFloat("direction", h);
    }
}

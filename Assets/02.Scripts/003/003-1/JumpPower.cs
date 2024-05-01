using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class JumpPower : MonoBehaviour
{
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // PC 버튼(Jump : Space) 을 누를때 한번 True
      
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
       
        // 모바일 터치 (차후 정리)
        // 터치 횟수 | 특정한 터치의 상태를 나타내는 오브젝트를 반환 : 화면에 터치가 시작된 상태
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //씬 전환 using UnityEngine.SceneManagement; ("씬이름")
        //Build 필요
        SceneManager.LoadScene("003-1_FlappyBird_Build");
    }
}

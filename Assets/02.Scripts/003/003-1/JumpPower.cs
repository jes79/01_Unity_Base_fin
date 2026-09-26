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
        // PC ��ư(Jump : Space) �� ������ �ѹ� True
      
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, jumpPower, 0);
        }
       
        // ����� ��ġ (���� ����)
        // ��ġ Ƚ�� | Ư���� ��ġ�� ���¸� ��Ÿ���� ������Ʈ�� ��ȯ : ȭ�鿡 ��ġ�� ���۵� ����
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, jumpPower, 0);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //�� ��ȯ using UnityEngine.SceneManagement; ("���̸�")
        //Build �ʿ�
        SceneManager.LoadScene("003-1_FlappyBird_Build");
    }
}

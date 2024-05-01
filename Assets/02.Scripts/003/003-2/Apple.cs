using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    //Static(정적 변수)는 클래스의 모든 인스턴스에서 공유
    public static float bottomY = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            // 메인 카메라의 ApplePicker 컴포넌트에 대한 참조를 얻음
            // 한 스크립트가 다른 스크립트의 함수를 호출 방법
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            // asScript의 공용 AppleDestroyed() 메서드 호출
            apScript.AppleDestroyed();
        }
    }
}

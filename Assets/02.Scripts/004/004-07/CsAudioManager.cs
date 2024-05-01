using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsAudioManager : MonoBehaviour
{
    //오디오 클립 타입의 변수를 선언
    public AudioClip clip;

    //충돌 감지 이벤트
    void OnCollisionEnter(Collision collision)
    {
        //오디오매니저 싱글톤 객체를 가져온 뒤
        //싱클톤 객체의 PlaySfx 메서드를 호출해 사운드를 출력
        AudioManager.Instance().PlaySfx(clip);
       
        //자기 자신을 게임에서 제거
        Destroy(this.gameObject);
    }

   
}

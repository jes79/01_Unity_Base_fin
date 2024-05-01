using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsDestroyDelayed : MonoBehaviour
{
    private AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        myAudio.Play();
        //오디오 클립이 출력되는 시간만틈 대기했다가 게임 오브젝트를 제거
        Destroy(this.gameObject, myAudio.clip.length);
    }
}

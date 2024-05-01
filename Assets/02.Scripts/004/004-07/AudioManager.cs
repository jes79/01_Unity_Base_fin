using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	//클래스 변수를 스태틱으로 선언
	static AudioManager _instance = null;

	//싱글톤 객체를 반환하기 위해 메서드를 스태틱으로 선언
	public static AudioManager Instance()
	{
		return _instance;
	}


	void Start()
	{
		//이 스크립트 컴포넌트를 가진 게임 오브젝트가 생성되어 메모리에 로드 될 때,
		//최초 실행이면 자기 자신을 선언한 클래스 타입 변수를 통해 반환하고
		//,최초 실행이 아니면 메모리에 이미 올라가 있는 스태틱 ㅂ클래스 변수를 찾아서 반환한다. 
		if (_instance == null)
        {
			_instance = this;
		}
			
	}

	public void PlaySfx(AudioClip clip)
	{
		//오디오소스 컴포넌트를 가져와 PlayOneShot 메서드를 통해 사운드를 출력
		GetComponent<AudioSource>().PlayOneShot(clip);
	}
}

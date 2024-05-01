using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCheck3DSound : MonoBehaviour
{

	float speed = 20.0f;

	void Update()
	{
		// 키보드 입력 
		float v = Input.GetAxis("Vertical");

		// 이동거리 보정
		v = v * speed * Time.deltaTime;

		// 실제 이동
		transform.Translate(Vector3.forward * v);

		// Play 3D Sound Check
		// In Audio Source, Change Spatial Blend. (2d - 3d)
		if (Input.GetButtonDown("Fire1"))
		{
			GetComponent<AudioSource>().Play();
		}
	}
}

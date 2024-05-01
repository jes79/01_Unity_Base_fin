using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMouseLook : MonoBehaviour
{
	public float sensitivity = 500.0f;
	public float rotationX;
	public float rotationY;

	void Update()
	{
		// 마우스 좌우로 이동 
		float mouseMoveValueX = Input.GetAxis("Mouse X");
		// 마우스 전후로 이동
		float mouseMoveValueY = Input.GetAxis("Mouse Y");
		
		//마우스의 좌우 이동 값을 누적시킨다.
		rotationX += mouseMoveValueX * sensitivity * Time.deltaTime;
		//마우스의 전후 이동 값은 누적시킨다.
		rotationY += mouseMoveValueY * sensitivity * Time.deltaTime;

		// 마우스 앞으로 이동
		if (rotationY > 20.0f)
			rotationY = 20.0f;
		// 마우스 뒤로 이동
		if (rotationY < -30.0f)
			rotationY = -30.0f;

		// 마우스 우로 이동
		if (rotationX > 90.0f)
        {
			rotationX = 90.0f;
		}
			
		//마우스 좌로 이동
		if (rotationX < -90.0f)
        {
			rotationX = -90.0f;
		}

		//rotationX,rotationY를 이용해 벡터값을 만들고 카메라의 회전 값으로 적용한다.
		transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);


	}
}

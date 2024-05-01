using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsGizmoView : MonoBehaviour
{
    //변수에 기즈모의 색을 지정
    public Color color = Color.green;
    //변수에 기즈모의 반지름을 지정
    public float radius = 0.5f;

    //기즈모가 그려지는 이벤트
    private void OnDrawGizmos()
    {
        // 기즈모의 색을 지정
        Gizmos.color = color;
        // 기즈모의 위치와 크기 지정
        Gizmos.DrawSphere(transform.position, radius);
    }
}

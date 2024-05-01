using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotateCube : MonoBehaviour
{
    //변수를 스태틱(정적)으로 선언
    public static int numX = 0;

    //두 개의 숫자를 더하는 메서드를 스태틱으로 선언
    public static int AddTwoNum (int x, int y)
    {
        return x + y;
    }

    //오른쪽으로 회전하는 메서드
    public void Rotate1()
    {
        transform.Rotate(Vector3.up * 90.0f);
    }
    //왼쪽으로 회전하는 메서드
    private void Rotate2()
    {
        transform.Rotate(Vector3.up * 90.0f * -1);
    }
}

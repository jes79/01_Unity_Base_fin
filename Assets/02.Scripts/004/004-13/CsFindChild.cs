using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsFindChild : MonoBehaviour
{
    //찾아온 자식 게임 오브젝트의 트랜스폼을 저장할 배열을 선언
    public Transform[] cubeChilds;
    // Start is called before the first frame update
    void Start()
    {
        //먼저 "Cube" 게임 오브젝트를 찾고 자식 객체들의 트랜스폼을 가져와 배열에 담는다.
        cubeChilds = GameObject.Find("Cube").GetComponentsInChildren<Transform>();

        //찾아온 자식 게임 오브젝트의 개수를 출력한다.
        Debug.Log("Cube의 자식 개수는 : " + (cubeChilds.Length -1) );
    
    }

}

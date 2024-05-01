using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> list = new List<int>();


        //리스트 더하기

        list.Add(1);

        list.Add(2);

        list.Add(3);



        //콘솔 보여주기

        foreach (var num in list)

        {

            print(num);

        }



        //현재 리스트 개수

        print("list Count : " + list.Count);



        //2 번째 인덱스 삭제

        list.RemoveAt(2);



        //현재 리스트 개수

        print("list Count : " + list.Count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

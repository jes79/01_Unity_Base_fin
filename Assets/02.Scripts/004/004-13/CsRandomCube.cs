using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRandomCube : MonoBehaviour
{
    List<int> cubeList = new List<int>();

    public GameObject cube;

    [Range(0, 100)]
    public int min;
    [Range(0, 100)]
    public int max;

    void Start()
    {
        //CreateDuplicateRandom(min, max);
        CreateUnDuplicateRandom(min, max);

        for (int i = 0; i < cubeList.Count; i++)
        {
            Debug.Log(cubeList[i]);
            Instantiate(cube, new Vector3(i, 0, cubeList[i]), Quaternion.identity);
        }
    }

    // 랜덤 생성 (중복 가능)
    void CreateDuplicateRandom(int min, int max)
    {
        for (int i = 0; i < max; i++)
        {
            cubeList.Add(Random.Range(min, max));
        }
    }

    // 랜덤 생성 (중복 배제)
    void CreateUnDuplicateRandom(int min, int max)
    {
        int currentNumber = Random.Range(min, max);

        //랜덤을 돌려 나온 값이 리스트에 존재하지 않는다면, 다시 랜덤을 돌리고
        //리스테에 존재한다면, 리스트에 해당 값을 추가해주고 증가 시켜줌
        for (int i = 0; i < max;)
        {
            if (cubeList.Contains(currentNumber))
            {
                currentNumber = Random.Range(min, max);
            }
            else
            {
                cubeList.Add(currentNumber);
                i++;
            }
        }
    }
}
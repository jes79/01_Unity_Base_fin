using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int randomSeedS;
        //randomSeedS = (int)System.DateTime.Now.Ticks;
        // Random.seed = randomSeedS;

        //Random.Range(이상, 미만)
        int randomX = Random.Range(5, 10);
        Debug.Log("integer : " + randomX);

        float randomY = Random.Range(5.0f, 10.0f);
        Debug.Log("float : " + randomY);

        //범위 제한
        //현재값이 최댓값보다 크면 그 최댓값까지만 출력해주고
        //최솟값보다 작으면 그 최솟값으로만 출력
        int myVal = 10;

        float nLimit = Mathf.Clamp(myVal, 1, 5);
        Debug.Log("Clamps : " + nLimit);
    }

}

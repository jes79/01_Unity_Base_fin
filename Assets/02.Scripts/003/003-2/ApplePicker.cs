using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    //Basket 게임오브젝트를 리스트에 저장하기 위해 선언
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        // baasketList 초기화
        basketList = new List<GameObject>();

        for (int i = 0; i < numBaskets; i++)
        {
            //tG숫자( 0 )
            GameObject tBasketG0 = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero; //  (0,0,0)
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketG0.transform.position = pos;

            // 바구니를 basketList에 저장. 바구니는 생성된 순서대로 저장되므로 아래쪽 부터 위쪽으로 추가
            basketList.Add(tBasketG0);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //떨어지는 사과를 삭제하고 바구니를 하나 삭제하는 메서드
    public void AppleDestroyed()
    {
        //tag 가 Apple 인 게임오브젝트를 찾아서 tAppleArray 배열에 저장
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        // 하나씩 커내서 디스트로이 함수로 삭제 (즉, 사과 모두 삭제)
        foreach ( GameObject tG0 in tAppleArray)
        {
            Destroy(tG0);
        }

        // 바구니 하나를 삭제함
        // basketList에서 마지막 바구니의 인덱스를 얻음
        int basketIndex = basketList.Count - 1;
        // 해당 Basket 게임오브젝트의 참고를 얻음
        GameObject tBasketG0 = basketList[basketIndex];
        //리스트에서 해당 바구니를 제거하고 게임오브젝트를 삭제함
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketG0);


        //씬 전환 using UnityEngine.SceneManagement; ("씬이름")
        //Build 필요
        //바스켓 갯수가 0개면
        if(basketList.Count == 0)
        {
            SceneManager.LoadScene("003-2_AppleTree");
        }
      
    }

    
}

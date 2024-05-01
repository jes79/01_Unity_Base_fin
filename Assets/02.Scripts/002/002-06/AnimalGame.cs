using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mouse jerry = new Mouse();  //  Mouse 객체생성    
        jerry.name = "Jerry";         //Animal로 부터 물려받은 속성
        jerry.weight = 1.5f;        //Animal로 부터 물려받은 속성
        jerry.age = 3;              //Animal로 부터 물려받은 속성

        Cat tom = new Cat(); // Cat 객체생성
        tom.name = "Tom";
        tom.weight = 5f;
        tom.age = 5;


        jerry.Stealth();// Mouse만 가기고 있는 기능(메소드)
        jerry.Print();  // 부모인 Animal로부터 물려받은 기능(메소드)

        tom.Hunt();   // Cat만 가지고 있는 기능(메소드)
        tom.Print();  // 부모인 Animal로부터 물려받은 기능(메소드)
    }

}

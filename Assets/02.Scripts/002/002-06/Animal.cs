using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal        // MonoBehaviour를 상속받지 않아 다른 오브젝트에 붙일 수 없음
{
    public string name;    //이름      
    public float weight;   //몸무게
    public int age;        //나이

    public void Print()
    {
        Debug.Log(name + "| 몸무게: " + weight + "| 나이: " + age);   //print() 대신 Debug.Log() 사용
    }

    public float GetSpeed()
    {
        float speed = 100f / (weight * age);

        return speed;
    }
}

public class  Cat : Animal   //Animal 클래스를 상속받는다.
{
    public void Hunt()
    {
        float speed = GetSpeed();  
        Debug.Log(speed + " 의 속도로 달려가서 사냥했다.");

        weight = weight + 1.2f;
        Debug.Log("사냥 후 몸무게가 늘어 " + weight + "몸무게가 되었다.");
    }
}


public class Mouse : Animal    //Animal 클래스를 상속받는다.
{
    public void Stealth()
    {
        Debug.Log("숨었다");
    }

}

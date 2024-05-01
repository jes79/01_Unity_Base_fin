using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //추가

public class CsSceneTrans : MonoBehaviour
{
   //첫 번째 씬으로 전환하는 메서드를 퍼블릭으로 선언
    public void SceneTrans01()
    {
        SceneManager.LoadScene("004-15-01_LoadScene");
    }

    //두 번째 씬으로 전환하는 메서드를 퍼블릭으로 선언
    public void SceneTrans02()
    {
        SceneManager.LoadScene("004-15-02_LoadScene");
    }
}

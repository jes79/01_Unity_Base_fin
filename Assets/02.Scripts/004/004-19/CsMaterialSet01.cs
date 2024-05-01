using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMaterialSet01 : MonoBehaviour
{
    //머티리얼을 저장할 변수를 배열 형태로 선언
    public Material[] colors;
    public Material[] boots;
    public Material[] pants;
    public Material[] shirt;
    //배열의 크기를 정해주었다. 어떤 차이가 있는지 확인해보자. 
    public Material[] helmet = new Material[2];

    //모델의 해당 부위를 지정할 게임오브젝트타입의 변수를 선언
    //기존 머티리얼을 사용하는부분
    //public GameObject arms;
    //public GameObject brows;
    //public GameObject hair;
    //public GameObject head;

    //기존 머티리얼이 적용될 게임오브젝트를 배열로 선언
    public GameObject[] baSe;

    public GameObject boots01;
    public GameObject boots02;
    public GameObject pants01;
    public GameObject pants02;
    public GameObject shirt01;
    public GameObject shirt02;
    public GameObject helmet01;
    public GameObject helmet02;

    //


    // Start is called before the first frame update
    void Start()
    {
        //CharMaterialSet(baSe[0], colors[0]);
        //CharMaterialSet(baSe[1], colors[0]);
        //CharMaterialSet(baSe[2], colors[0]);
        //CharMaterialSet(baSe[3], colors[0]);

        //기존 머티리얼이 적용될 게임오브젝트를 포이치(루프)를 이용해 머티리어을 적용
        foreach (GameObject bAse in baSe)
        {
            CharMaterialSet(bAse, colors[0]);
        }

        CharMaterialSet(boots01, boots[0]);
        CharMaterialSet(boots02, boots[1]);

        CharMaterialSet(pants01, pants[0]);
        CharMaterialSet(pants02, pants[1]);

        CharMaterialSet(shirt01, shirt[0]);
        CharMaterialSet(shirt02, shirt[1]);

        CharMaterialSet(helmet01, helmet[0]);
        CharMaterialSet(helmet02, helmet[1]);
    }

   public void CharMaterialSet (GameObject obj, Material mat)
    {
        obj.GetComponent<Renderer>().material = mat;
    }
}

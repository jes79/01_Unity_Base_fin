using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotateAnim : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
  
    void FrontImage()
    {
        GetComponent<Renderer>().material = mat1;
    }

    void BackImage()
    {
        GetComponent<Renderer>().material = mat2;
    }
}

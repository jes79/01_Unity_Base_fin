using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsRandomGacha : MonoBehaviour
{
    public List<string> gachaList = new List<string>();
    public int numberOfTutee;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        Gacha();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Gacha()
    {
        for (int i = 0; i < numberOfTutee ; i++)
        {
            int rand = Random.Range(0, gachaList.Count);
            

            txt.text += "\n" + "<color=#ff0000>" + (i + 1) + "</color>" + " 번째 발표자는 " + "<color=#0000ff>" + gachaList[rand] + "</color>" + "님 입니다." ;

            gachaList.RemoveAt(rand);
        }
    }
   
}

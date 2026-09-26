using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CsTitleScreen : MonoBehaviour
{

    [SerializeField] private string nextSceneName = "004-21-02_KeyFrameAnimation";
    Quaternion orignalRot;

    // Start is called before the first frame update
    void Start()
    {
        orignalRot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation =
            Quaternion.AngleAxis (Mathf.Sin(2.0f * Time.time) * 20.0f, Vector3.up) *
            Quaternion.AngleAxis (Mathf.Sin(2.7f * Time.time) * 33.3f, Vector3.right) *
            orignalRot;

        transform.parent.localRotation =
           Quaternion.AngleAxis(Time.deltaTime, Vector3.up) *
           transform.parent.localRotation;

        if (Input.GetButtonDown("Jump"))
        {
            if (Application.CanStreamedLevelBeLoaded(nextSceneName))
                SceneManager.LoadScene(nextSceneName);
            else
                Debug.LogError("Add the target scene to Build Profiles: " + nextSceneName, this);
        }

    }
}

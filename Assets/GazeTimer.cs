using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GazeTimer : MonoBehaviour
{
    public static GazeTimer Instance;

    public static float myTime = 0.0f;
    public Transform GazeImg;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {

        GazeImg.GetComponent<Image>().fillAmount = myTime;
    }

    // Update is called once per frame
    void Update()
    {
        GazeImg.GetComponent<Image>().fillAmount = myTime/3;

        myTime += Time.deltaTime;
        if (myTime >= 3.0f)
        {
            ButtonVR.Instance.OnMouseDown();

        }

    }
    public void Recomecar()
    {
        myTime = 0.0f;

        GazeImg.GetComponent<Image>().fillAmount = myTime / 3;

    }

}

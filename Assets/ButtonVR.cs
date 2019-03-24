using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonVR : MonoBehaviour
{
    public static ButtonVR Instance;


    public string levelName;
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

        public void OnMouseDown()
    {
        StartCoroutine(FadeAndLoad());
    }

    IEnumerator FadeAndLoad()
    {
       // loading.FadeIn();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}

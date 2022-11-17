using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneload : MonoBehaviour
{
    public Slider progressbar;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync("HRH_Scene_3");
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            yield return null;
            if(progressbar.value < 1f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);
            }
            else
            {
                operation.allowSceneActivation = true;
            }
        }
    }

}

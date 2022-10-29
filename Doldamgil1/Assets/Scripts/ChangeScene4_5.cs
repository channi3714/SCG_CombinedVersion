using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene4_5 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public GameObject Window11;
    public GameObject Back;
    public Text SceneChangeText;

    int cnt = 0;

    public void OnClickChange4_5()
    {
        cnt++;
        if (cnt == 1)
        {
            Back.transform.localScale = Vector3.one;

            Window11.transform.localScale = Vector3.one;
            SceneChangeText.transform.localScale = Vector3.zero;
        }
        else if (cnt == 2)
        {
            SceneManager.LoadScene("DDG_Scene_5");
        }
        //print(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        Back.transform.localScale = Vector3.zero;
        Window11.transform.localScale = Vector3.zero;
        SceneChangeText.text = "쓰레기를 터치해서 치워주세요!!";
        ButtonChangeScene.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 10)
        {
            SceneChangeText.text = "쓰레기를 다 치웠다면,\nOK버튼을 눌러주세요!";
            ButtonChangeScene.transform.localScale = Vector3.one;
        }
    }
}

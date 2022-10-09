using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene2_3 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public Text SceneChangeText;

    public void OnClickChange2_3()
    {
        SceneManager.LoadScene("DDG_Scene_3");
        //print(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneChangeText.text = "";
        ButtonChangeScene.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 5)
        {
            SceneChangeText.text = "장미 조형물에 도착하면 아래 버튼을 눌러주세요.";
            ButtonChangeScene.transform.localScale = Vector3.one;
        }
    }
}

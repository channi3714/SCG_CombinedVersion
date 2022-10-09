using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene6_7 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public Text SceneChangeText;

    public void OnClickChange6_7()
    {
        SceneManager.LoadScene("HBH_Scene_1");
        //print(1);
        //print("Next Scene");
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
            SceneChangeText.text = "정동극장에 도착하면 아래 버튼을 눌러주세요!";
            ButtonChangeScene.transform.localScale = Vector3.one;
        }
    }
}

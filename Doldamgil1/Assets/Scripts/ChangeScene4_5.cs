using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene4_5 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public Text SceneChangeText;

    public void OnClickChange4_5()
    {
        SceneManager.LoadScene("DDG_Scene_5");
        //print(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneChangeText.text = "쓰레기를 터치해서 치워주세요!!";
        ButtonChangeScene.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 5)
        {
            SceneChangeText.text = "쓰레기를 다 치웠다면 OK버튼을 눌러주세요!";
            ButtonChangeScene.transform.localScale = Vector3.one;
        }
    }
}

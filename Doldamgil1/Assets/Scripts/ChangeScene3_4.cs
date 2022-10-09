using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene3_4 : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public Text TalkText;
    int count = 0;

    public void OnClickChange3_4()
    {
        count++;
        if (count == 0)
        {
            ButtonText.text = "TALK";
            TalkText.text = "정원사를 찾아, TALK 버튼을 눌러\n정원사 AI와 대화를 나눠보세요!";
        }
        else if (count == 1)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "대화 1";
        }
        else if (count == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "대화 2";
        }
        else if (count == 3)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "대화 1";
        }
        else if (count == 4)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "대화 2";
        }
        else if (count == 5)
        {
            ButtonText.text = "OK";
            TalkText.text = "OK를 눌러 정원사가 부탁한 일을 마무리하자";
        }
        else if (count == 6)
        {
            SceneManager.LoadScene("DDG_Scene_4");
        }
        Debug.Log("count:" + count);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

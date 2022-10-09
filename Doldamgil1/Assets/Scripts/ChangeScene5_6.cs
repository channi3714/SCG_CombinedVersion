using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene5_6 : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public Text TalkText;
    public int cnt = 0;

    public void OnClickChange5_6()
    {
        cnt++;
        if (cnt == 0)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "대화2";
        }
        else if (cnt == 1)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "CCTV자료 획득";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "고마워";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "주인을 찾길 바랄게";
        }
        else if (cnt == 4)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "주인이 아니야....";
        }
        else if (cnt == 5)
        {
            ButtonText.text = "OK";
            TalkText.text = "레이더를 피해 정동극장으로 이동하자";
        }
        else if (cnt == 6)
        {
            SceneManager.LoadScene("DDG_Scene_6");
        }
        Debug.Log("cnt:" + cnt);
    }

    // Start is called before the first frame update
    void Start()
    {
        TalkText.text = "대화2";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

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
            TalkText.text = "��ȭ2";
        }
        else if (cnt == 1)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "CCTV�ڷ� ȹ��";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "����";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "������ ã�� �ٶ���";
        }
        else if (cnt == 4)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "������ �ƴϾ�....";
        }
        else if (cnt == 5)
        {
            ButtonText.text = "OK";
            TalkText.text = "���̴��� ���� ������������ �̵�����";
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
        TalkText.text = "��ȭ2";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CS_HBH_3_4 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public Text TalkText;
    public int cnt = 0;

    public void HBH_3_4()
    {
        cnt++;
        if (cnt == 1)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "��ȭ�� ã�ƺ���.";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "�� ���� ��Ϲ����� ���캸��.";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "CLICK";
            TalkText.text = "å�� ���� �ں񽺸� Ŭ���غ���.";
        }
        else if (cnt == 4)
        {
            SceneManager.LoadScene("HBH_Scene_4");
        }
        Debug.Log("cnt:" + cnt);

    }

    // Start is called before the first frame update
    void Start()
    {
        TalkText.text = "<��ŷ �Ϸ�>\n���� ���ȴ�. ������ ����.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

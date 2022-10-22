using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CS_HBH_3_4 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public GameObject talk_1;
    public GameObject talk_2;
    public GameObject Wall_Image;
    public GameObject mission_pattern;
    public GameObject background;
    public Text ButtonText;
    public Text TalkText;
    public int cnt = 0;

    public void HBH_3_4()
    {
        cnt++;
        if (cnt == 1)
        {
            ButtonText.text = "NEXT >>";
            talk_1.transform.localScale = Vector3.zero;
            talk_2.transform.localScale = Vector3.one;
            //TalkText.text = "��ȭ�� ã�ƺ���.";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT >>";
            background.transform.localScale = Vector3.zero;
            talk_2.transform.localScale = Vector3.zero;
            Wall_Image.transform.localScale = Vector3.one;
            //TalkText.text = "�� ���� ��Ϲ����� ���캸��.";
        }
        else if (cnt == 3)
        {
            background.transform.localScale = Vector3.one;
            Wall_Image.transform.localScale = Vector3.zero;
            mission_pattern.transform.localScale = Vector3.one;
            ButtonText.text = "OK";
            //TalkText.text = "å�� ���� �ں񽺸� Ŭ���غ���.";
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
        ButtonText.text = "NEXT >>";
        //TalkText.text = "<��ŷ �Ϸ�>\n���� ���ȴ�. ������ ����.";
        talk_2.transform.localScale = Vector3.zero;
        Wall_Image.transform.localScale = Vector3.zero;
        mission_pattern.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

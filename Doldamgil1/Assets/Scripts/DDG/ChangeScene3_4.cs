using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene3_4 : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public GameObject Window4;
    public GameObject Window5;
    public GameObject Window6;
    public GameObject Window7;
    public GameObject Window8;
    public GameObject Window9;
    public GameObject Window10;
    public GameObject Back;
    //public Text TalkText;
    int count = 0;

    public void OnClickChange3_4()
    {
        count++;
        if (count == 1)
        {
            Back.transform.localScale = Vector3.one;

            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.one;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            Window8.transform.localScale = Vector3.zero;
            Window9.transform.localScale = Vector3.zero;
            Window10.transform.localScale = Vector3.zero;
            ButtonText.text = "OK";
            //TalkText.text = "�����縦 ã��, TALK ��ư�� ����\n������ AI�� ��ȭ�� ����������!";
        }
        else if (count == 2)
        {
            Back.transform.localScale = Vector3.zero;

            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.one;
            Window7.transform.localScale = Vector3.zero;
            Window8.transform.localScale = Vector3.zero;
            Window9.transform.localScale = Vector3.zero;
            Window10.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
            //TalkText.text = "��ȭ 1";
        }
        else if (count == 3)
        {
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.one;
            Window8.transform.localScale = Vector3.zero;
            Window9.transform.localScale = Vector3.zero;
            Window10.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
            //TalkText.text = "��ȭ 2";
        }
        else if (count == 4)
        {
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            Window8.transform.localScale = Vector3.one;
            Window9.transform.localScale = Vector3.zero;
            Window10.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
            //TalkText.text = "��ȭ 1";
        }
        else if (count == 5)
        {
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            Window8.transform.localScale = Vector3.zero;
            Window9.transform.localScale = Vector3.one;
            Window10.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
            //TalkText.text = "��ȭ 2";
        }
        else if (count == 6)
        {
            Back.transform.localScale = Vector3.one;

            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            Window8.transform.localScale = Vector3.zero;
            Window9.transform.localScale = Vector3.zero;
            Window10.transform.localScale = Vector3.one;
            ButtonText.text = "OK";
            //TalkText.text = "OK�� ���� �����簡 ��Ź�� ���� ����������";
        }
        else if (count == 7)
        {
            SceneManager.LoadScene("DDG_Scene_4");
        }
        Debug.Log("count:" + count);
    }

    // Start is called before the first frame update
    void Start()
    {
        ButtonText.text = "NEXT >>";
        Window4.transform.localScale = Vector3.one;
        Window5.transform.localScale = Vector3.zero;
        Window6.transform.localScale = Vector3.zero;
        Window7.transform.localScale = Vector3.zero;
        Window8.transform.localScale = Vector3.zero;
        Window9.transform.localScale = Vector3.zero;
        Window10.transform.localScale = Vector3.zero;
        Back.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

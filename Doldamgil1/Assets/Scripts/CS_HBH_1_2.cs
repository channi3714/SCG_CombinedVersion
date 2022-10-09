using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//------------------------ Change Scene Husband House 1 to 2. ------------------------//

public class CS_HBH_1_2 : MonoBehaviour
{
    public float TotalTime;
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public Text TalkText;
    public int cnt = 0;
    bool tf = true;
    private Touch DoorTouch;

    public void HBH_1_2()
    {
        cnt++;
        if (cnt == 1)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "문을 클릭해서 열어보자.";
            tf = false;
            ButtonChangeScene.transform.localScale = Vector3.zero;
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "!!Warning!! 홍채 인식 실패";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "시간이 없다! 해킹하자!";
        }
        else if (cnt == 4)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "<해킹 미션>\n힌트:남편과 해리엇의 추억";
        }
        else if (cnt == 5)
        {
            ButtonText.text = "OK";
            TalkText.text = "OK를 눌러 미션을 시작하자";
        }
        else if (cnt == 6)
        {
            SceneManager.LoadScene("HBH_Scene_2");
        }
        Debug.Log("cnt:" + cnt);

    }

    // Start is called before the first frame update
    void Start()
    {
        TalkText.text = "해리엇의 남편 귀가 시간은 6시.\n 지금은 5시 30분. 문을 열고 들어가자.";
        ButtonChangeScene.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 5 && tf)
        {
            ButtonChangeScene.transform.localScale = Vector3.one;
        }
        else if (TotalTime > 5 && tf == false)
        {
            ButtonChangeScene.transform.localScale = Vector3.zero;
        }
        //Debug.Log("touchcount:" + Input.touchCount);
        if (Input.touchCount > 0 && tf == false)
        {
            tf = true;
            HBH_1_2();
        }
        //DoorTouch = Input.GetTouch(0);
        //if (DoorTouch.phase == TouchPhase.Began && tf == false)
        //{
        //    HBH_1_2();
        //}
    }
}

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
            TalkText.text = "벽화를 찾아보자.";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT";
            TalkText.text = "집 안의 기록물들을 살펴보자.";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "CLICK";
            TalkText.text = "책상 위의 자비스를 클릭해보자.";
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
        TalkText.text = "<해킹 완료>\n문이 열렸다. 안으로 들어가자.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

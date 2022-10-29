using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene1_2 : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Back;
    public int cnt = 0;

    public void OnClickChange1_2()
    {
        cnt++;

        if (cnt == 1)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.one;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 2)
        {
            Back.transform.localScale = Vector3.one;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.one;
            ButtonText.text = "OK";
        }
        else if (cnt == 3)
        {
            SceneManager.LoadScene("DDG_Scene_2");
        }
        Debug.Log("cnt:" + cnt);
    }

    // Start is called before the first frame update
    void Start()
    {
        ButtonText.text = "NEXT >>";
        Back.transform.localScale = Vector3.zero;
        Window2.transform.localScale = Vector3.zero;
        Window3.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene5_6 : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public Text ButtonText;
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    public int cnt = 0;

    public void OnClickChange5_6()
    {
        cnt++;
       
       if (cnt == 1)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.one;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 2)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.one;
            Window4.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 3)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.one;
            ButtonText.text = "OK";
        }
        else if (cnt == 4)
        {
            SceneManager.LoadScene("DDG_Scene_6");
        }
        Debug.Log("cnt:" + cnt);
    }

    // Start is called before the first frame update
    void Start()
    {
        Window1.transform.localScale = Vector3.one;
        Window2.transform.localScale = Vector3.zero;
        Window3.transform.localScale = Vector3.zero;
        Window4.transform.localScale = Vector3.zero;
        ButtonText.text = "NEXT >>";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

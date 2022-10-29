using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject ButtonChangeScene;
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public Text ButtonText;
    public int cnt = 0;

    public void OnClickChange1_2()
    {
        cnt++;

        if (cnt == 1)
        {
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 2)
        {
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 3)
        {
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 4)
        {
            ButtonText.text = "OK";
        }
        else if (cnt == 5)
        {
            SceneManager.LoadScene("DDG_Scene_6");
        }
        Debug.Log("cnt:" + cnt);
    }

    // Start is called before the first frame update
    void Start()
    {
            ButtonText.text = "NEXT >>";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

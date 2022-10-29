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
    public GameObject Back;
    public GameObject Back2;
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    public GameObject Window5;
    public GameObject Window6;
    public GameObject Window7;

    public int cnt = 0;

    public void HBH_1_2()
    {
        cnt++;
        if (cnt == 1)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.one;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 2)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.one;
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            ButtonText.text = "OK";
        }
        else if (cnt == 3)
        {
            Back2.transform.localScale = Vector3.one;

            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.one;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            ButtonText.text = "OK";
        }
        else if (cnt == 4)
        {
            Back2.transform.localScale = Vector3.zero;

            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.one;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 5)
        {
            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.one;
            Window7.transform.localScale = Vector3.zero;
            ButtonText.text = "NEXT >>";
        }
        else if (cnt == 6)
        {
            Back.transform.localScale = Vector3.one;

            Window1.transform.localScale = Vector3.zero;
            Window2.transform.localScale = Vector3.zero;
            Window3.transform.localScale = Vector3.zero;
            Window4.transform.localScale = Vector3.zero;
            Window5.transform.localScale = Vector3.zero;
            Window6.transform.localScale = Vector3.zero;
            Window7.transform.localScale = Vector3.one;
            ButtonText.text = "OK";
        }
        else if (cnt == 7)
        {
            SceneManager.LoadScene("HBH_Scene_2");
        }
        Debug.Log("cnt:" + cnt);

    }

    // Start is called before the first frame update
    void Start()
    {
        Back.transform.localScale = Vector3.zero;
        Back2.transform.localScale = Vector3.zero;
        Window1.transform.localScale = Vector3.one;
        Window2.transform.localScale = Vector3.zero;
        Window3.transform.localScale = Vector3.zero;
        Window4.transform.localScale = Vector3.zero;
        Window5.transform.localScale = Vector3.zero;
        Window6.transform.localScale = Vector3.zero;
        Window7.transform.localScale = Vector3.zero;
        ButtonChangeScene.transform.localScale = Vector3.one;
        ButtonText.text = "NEXT >>";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}

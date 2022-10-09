using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene1_2 : MonoBehaviour
{
    public GameObject ButtonSceneChange;
    //private bool isClick = false;

    public void OnClickChange1_2()
    {
        SceneManager.LoadScene("DDG_Scene_2");
    }
     //SceneManager.LoadScene("DDG_Scene_1");
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

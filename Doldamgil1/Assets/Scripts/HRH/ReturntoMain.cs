using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMain : MonoBehaviour
{
    private string main = "HRH_Scene_2";
    // Start is called before the first frame update
    public void GoToMain()
    {
        SceneManager.LoadScene(main);
    }

}

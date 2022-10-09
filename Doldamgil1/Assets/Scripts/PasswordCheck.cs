using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasswordCheck : MonoBehaviour
{
    private string password = "4122";
    public InputField UserInput;
    public string USERINPUT;

    private string correct = "HBH_Scene_3";
    private string wrong = "HBH_Wrong";

    // Start is called before the first frame update
    public void CheckPassword()
    {
        USERINPUT = UserInput.text;

        if (USERINPUT != null)
        {
            if (USERINPUT == password)
            {
                SceneManager.LoadScene(correct);
            }
            else
            {
                SceneManager.LoadScene(wrong);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
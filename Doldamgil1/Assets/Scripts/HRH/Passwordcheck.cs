using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Passwordcheck : MonoBehaviour
{
    private string password = "1080";
    public InputField UserInput;
    public string USERINPUT;

    private string correct = "HRH_Correct";
    private string wrong = "HRH_Wrong";

    // Start is called before the first frame update
    public void CheckPassword()
    {
        USERINPUT = UserInput.text;

        if(USERINPUT != null)
        {
            if(USERINPUT == password)
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

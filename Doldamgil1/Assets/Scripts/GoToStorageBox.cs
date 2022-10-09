using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStorageBox : MonoBehaviour
{
    private string main = "HBH_Storage_Box";
    // Start is called before the first frame update
    public void StorageBox()
    {
        SceneManager.LoadScene(main);
    }

}
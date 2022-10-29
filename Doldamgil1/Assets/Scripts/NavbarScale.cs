using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavbarScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 myVector = new Vector2(Screen.width, Screen.height / 20);
        transform.gameObject.GetComponent<RectTransform>().sizeDelta = myVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

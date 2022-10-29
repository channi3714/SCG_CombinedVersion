using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random : MonoBehaviour
{
    public float TotalTime;
    public Text RandomTimeText;
    public Text TotalTimeText;
    public Text ClickTimeText;
    public Text AlertText;
    public GameObject ButtonAlert;
    public GameObject PanelAlert;
    public GameObject Warning;

    private float clickTime;
    public float minClickTime = 1;
    private bool isClick;
    private bool check = true;

    public void ButtonDown()
    {
        isClick = true;
    }
    public void ButtonUp()
    {
        isClick = false;
        print(clickTime);

        if (clickTime >= minClickTime)
        {
            //ButtonAlert.SetActive(false);
        }
    }
    int random = -1;
    int ck = 0;
    // Start is called before the first frame update
    void Start()
    {
        Warning.transform.localScale = Vector3.zero;
        PanelAlert.transform.localScale = Vector3.zero;
        ButtonAlert.transform.localScale = Vector3.zero;
        //ButtonAlert.SetActive(!ButtonAlert.active);
    }

    // Update is called once per frame
    void Update()
    {
        if (random <= 0)
        {
            Warning.transform.localScale = Vector3.zero;

            AlertText.text = "";
            PanelAlert.transform.localScale = Vector3.zero;
            ButtonAlert.transform.localScale = Vector3.zero;
            random = UnityEngine.Random.Range(-300, 2);
            RandomTimeText.text = random.ToString();
            clickTime = 0;
            ck = 0;
        }
        else if (random > 0)
        {
            AlertText.text = "프로텍터 AI의 동작시간입니다!\n하단의 버튼을 5초간 눌러 프로텍터 AI를 피하세요!";
            Warning.transform.localScale = Vector3.one;

            ButtonAlert.transform.localScale = Vector3.one;
            ck++;
            if (check == true)
            {
                PanelAlert.transform.localScale = Vector3.zero;
                if (ck > 10)
                {
                    check = false;
                    ck = 0;
                }
                
            }
            else if(check == false)
            {
                PanelAlert.transform.localScale = Vector3.one;
                if (ck > 10)
                {
                    check = true;
                    ck = 0;
                }
            }
            //PanelAlert.transform.localScale = Vector3.one;
        }
        
        if (isClick)
        {
            clickTime += Time.deltaTime;
            if (clickTime > 5)
            {
                random = 0;
            }
        }
        else
        {
            //ButtonAlert.SetActive(false);
            //random = UnityEngine.Random.Range(-10, 2);
            //RandomTimeText.text = random.ToString();
            //clickTime = 0;
            if (random > 0)
            {
                //ButtonAlert.SetActive(true);
            }
        }

        ClickTimeText.text = "클릭 시간 : " + Mathf.Round(clickTime);
        TotalTime += Time.deltaTime;
        //random = UnityEngine.Random.Range(-10, 1);
        //RandomTimeText.text = random.ToString();
        TotalTimeText.text = "총 시간 : " + Mathf.Round(TotalTime);
        print(random);
        //Debug.Log("난수 발생, -5 부터 5사이." + random);
        //Debug.Log("시간" + TotalTime);
    }
}

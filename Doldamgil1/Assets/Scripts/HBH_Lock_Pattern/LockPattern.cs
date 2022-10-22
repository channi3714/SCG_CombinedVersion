using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockPattern : MonoBehaviour
{
    public GameObject linePrefab;
    public Canvas canvas;
    public Text ConditionText;

    private Dictionary<int, CircleIdentifier> circles;

    private List<CircleIdentifier> lines;

    private GameObject lineOnEdit;
    private RectTransform lineOnEditRcTs;
    private CircleIdentifier circleOnEdit;

    private bool unlocking;
    private bool repCheck = true;

    new bool enabled = true;

    private List<int> correctPattern;
    private List<int> userPattern;

    // Start is called before the first frame update
    void Start()
    {
        ConditionText.text = "";

        circles = new Dictionary<int, CircleIdentifier>();
        lines = new List<CircleIdentifier>();
        correctPattern = new List<int>();
        userPattern = new List<int>();

        correctPattern.Add(0);
        correctPattern.Add(4);
        correctPattern.Add(2);
        correctPattern.Add(5);
        correctPattern.Add(7);
        correctPattern.Add(3);

        /*foreach(int pat in correctPattern)
        {
            Debug.Log(pat);
        }*/

        for (int i = 0; i < transform.childCount; i++)
        {
            var circle = transform.GetChild(i);

            var identifier = circle.GetComponent<CircleIdentifier>();

            identifier.id = i;

            circles.Add(i, identifier);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled == false)
        {
            return;
        }

        if (unlocking)
        {
            Vector3 mousePos = canvas.transform.InverseTransformPoint(Input.mousePosition);
            mousePos.x -= 15.3f;
            mousePos.y += 180f;

            lineOnEditRcTs.sizeDelta = new Vector2(lineOnEditRcTs.sizeDelta.x, Vector3.Distance(mousePos, circleOnEdit.transform.localPosition));

            lineOnEditRcTs.rotation = Quaternion.FromToRotation(
                Vector3.up,
                (mousePos - circleOnEdit.transform.localPosition).normalized);
        }
    }

    IEnumerator Release()
    {
        enabled = false;

        string result = "";

        //3초 대기
        yield return new WaitForSeconds(3);

        foreach(int pat in userPattern)
        {
            result += pat.ToString();
            Debug.Log("res" + pat);
        }
        //ConditionText.text = result;
        for (int i = 0; i < 6; i++)
        {
            if(userPattern[i] != correctPattern[i])
            {
                ConditionText.text = result + "\n잘못된 접근입니다.";
                userPattern.Clear();
                break;
            }
            else
            {
                if (i == 5)
                {
                    SceneManager.LoadScene("HBH_Scene_5");
                }
            }
            
        }

        foreach(var circle in circles)
        {
            circle.Value.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            circle.Value.GetComponent<Animator>().enabled = false;
        }

        foreach (var line in lines)
        {
            Destroy(line.gameObject);
        }

        lines.Clear();

        lineOnEdit = null;
        lineOnEditRcTs = null;
        circleOnEdit = null;

        enabled = true;
    }
    GameObject CreateLine(Vector3 pos, int id)
    {
        var line = GameObject.Instantiate(linePrefab, canvas.transform);

        pos.x += 15.3f;
        pos.y -= 180f;

        line.transform.localPosition = pos;

        var lineIdf = line.AddComponent<CircleIdentifier>();

        lineIdf.id = id;

        lines.Add(lineIdf);

        return line;
    }

    void TrySetLineEdit(CircleIdentifier circle)
    {
        foreach(var line in lines)
        {
            if(line.id == circle.id)
            {
                return;
            }
        }
        Vector3 vector;
        vector = circle.transform.localPosition;
        /*vector.x += 15.3f;
        vector.y -= 180f;*/
        lineOnEdit = CreateLine(vector, circle.id);
        lineOnEditRcTs = lineOnEdit.GetComponent<RectTransform>();
        circleOnEdit = circle;

    }

    void EnableColorFade(Animator anim)
    {
        anim.enabled = true;
        anim.Rebind();
    }

    public void OnMouseEnterCircle(CircleIdentifier idf)
    {
        if (enabled == false)
        {
            return;
        }

        //Debug.Log(idf.id);

        if (unlocking)
        {
            lineOnEditRcTs.sizeDelta = new Vector2(lineOnEditRcTs.sizeDelta.x, Vector3.Distance(circleOnEdit.transform.localPosition, idf.transform.localPosition));
            lineOnEditRcTs.rotation = Quaternion.FromToRotation(
                Vector3.up,
                (idf.transform.localPosition - circleOnEdit.transform.localPosition).normalized);

            TrySetLineEdit(idf);
            
            foreach(int pat in userPattern)
            {
                if (pat == idf.id)
                {
                    repCheck = false;
                }
                
            }
            if (userPattern.Count == 0)
            {
                repCheck = true;
            }
            if (repCheck)
            {
                userPattern.Add(idf.id);
                ConditionText.text = idf.id.ToString();
                Debug.Log(idf.id);
            }
            repCheck = true;
        }
    }
    public void OnMouseExitCircle(CircleIdentifier idf)
    {
        if (enabled == false)
        {
            return;
        }
        //Debug.Log(idf.id);
    }
    public void OnMouseDownCircle(CircleIdentifier idf)
    {
        if (enabled == false)
        {
            return;
        }
        ConditionText.text = "";

        //Debug.Log(idf.id);

        unlocking = true;

        TrySetLineEdit(idf);
    }
    public void OnMouseUpCircle(CircleIdentifier idf)
    {
        if (enabled == false)
        {
            return;
        }

        //Debug.Log(idf.id);

        if (unlocking)
        {
            foreach(var line in lines)
            {
                EnableColorFade(circles[line.id].gameObject.GetComponent<Animator>());
            }

            Destroy(lines[lines.Count - 1].gameObject);
            lines.RemoveAt(lines.Count - 1);

            foreach(var line in lines)
            {
                EnableColorFade(line.GetComponent<Animator>());
            }

            StartCoroutine(Release());
        }

        unlocking = false;

        
    }

}

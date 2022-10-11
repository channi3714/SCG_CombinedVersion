using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPattern : MonoBehaviour
{
    public GameObject linePrefab;
    public Canvas canvas;
    
    private Dictionary<int, CircleIdentifier> circles;

    private List<CircleIdentifier> lines;

    private GameObject lineOnEdit;
    private RectTransform lineOnEditRcTs;
    private CircleIdentifier circleOnEdit;

    private bool unlocking;

    // Start is called before the first frame update
    void Start()
    {
        circles = new Dictionary<int, CircleIdentifier>();
        lines = new List<CircleIdentifier>();

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
        if (unlocking)
        {
            Vector3 mousePos = canvas.transform.InverseTransformPoint(Input.mousePosition);

            lineOnEditRcTs.sizeDelta = new Vector2(lineOnEditRcTs.sizeDelta.x, Vector3.Distance(mousePos, circleOnEdit.transform.localPosition));

            lineOnEditRcTs.rotation = Quaternion.FromToRotation(
                Vector3.up,
                (mousePos - circleOnEdit.transform.localPosition).normalized);
        }
    }

    GameObject CreateLine(Vector3 pos, int id)
    {
        var line = GameObject.Instantiate(linePrefab, canvas.transform);

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

        lineOnEdit = CreateLine(circle.transform.localPosition, circle.id);
        lineOnEditRcTs = lineOnEdit.GetComponent<RectTransform>();
        circleOnEdit = circle;

    }
    public void OnMouseEnterCircle(CircleIdentifier idf)
    {
        //Debug.Log(idf.id);
    }
    public void OnMouseExitCircle(CircleIdentifier idf)
    {
        //Debug.Log(idf.id);
    }
    public void OnMouseDownCircle(CircleIdentifier idf)
    {
        //Debug.Log(idf.id);

        unlocking = true;

        TrySetLineEdit(idf);
    }
    public void OnMouseUpCircle(CircleIdentifier idf)
    {
        //Debug.Log(idf.id);

        unlocking = false;

        foreach(var line in lines)
        {
            //Destroy(line.gameObject);
        }

        lines.Clear();

        lineOnEdit = null;
        lineOnEditRcTs = null;
        circleOnEdit = null;

    }

}

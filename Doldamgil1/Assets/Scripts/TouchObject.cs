using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchObject : MonoBehaviour
{
    //������ ��ü 
    private GameObject placeObject;
    private ARRaycastManager raycastMgr;
    public List<ARRaycastHit> hits = new List<ARRaycastHit>();
    [SerializeField]
    private Text textUI;

    private bool Touched = false;
    private GameObject SelectedObj;
    [SerializeField]
    private Camera arCamera;

    void Start()
    {
        // AR Raycast Manager ���� 
        raycastMgr = GetComponent<ARRaycastManager>();
    }
    void Update()
    {
        textUI.text = "test";
        if (Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);
        //textUI.text = "Touch Count";

        //��ġ ���۽�
        if (touch.phase == TouchPhase.Began)
        {
            textUI.text = "Touch Started";
            Ray ray;
            RaycastHit hitobj;
            //print("touch");

            ray = arCamera.ScreenPointToRay(touch.position);

            //Ray�� ���� ������Ʈ �ν�
            if (Physics.Raycast(ray, out hitobj))
            {
                textUI.text = "raycast1";
                //��ġ�� ���� ������Ʈ �̸��� Cube�� �����ϸ�
                //if (hitobj.collider.name == "Rose")
                //{
                textUI.text = hitobj.collider.name;
                //�� ������Ʈ�� SelectObj�� ���´� //��ġ�ϰ� �ִ´�
                SelectedObj = hitobj.collider.gameObject;
                Touched = true;
                Destroy(SelectedObj);
                //}
            }
        }
        //��ġ�� ������ ��ġ ��.
        if (touch.phase == TouchPhase.Ended)
        {
            Touched = false;
        }

        if (raycastMgr.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            textUI.text = "raycast2";
            //��ġ �� �ش� ������Ʈ ����
            if (hits.Count > 0)
            {
                textUI.text = hits[0].trackableId.ToString();
            }
            if (Touched)
            {
                textUI.text = "touched";
                Destroy(SelectedObj);
            }
        }
    }
}

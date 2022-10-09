using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchObject : MonoBehaviour
{
    //생성할 객체 
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
        // AR Raycast Manager 추출 
        raycastMgr = GetComponent<ARRaycastManager>();
    }
    void Update()
    {
        textUI.text = "test";
        if (Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);
        //textUI.text = "Touch Count";

        //터치 시작시
        if (touch.phase == TouchPhase.Began)
        {
            textUI.text = "Touch Started";
            Ray ray;
            RaycastHit hitobj;
            //print("touch");

            ray = arCamera.ScreenPointToRay(touch.position);

            //Ray를 통한 오브젝트 인식
            if (Physics.Raycast(ray, out hitobj))
            {
                textUI.text = "raycast1";
                //터치한 곳에 오브젝트 이름이 Cube를 포함하면
                //if (hitobj.collider.name == "Rose")
                //{
                textUI.text = hitobj.collider.name;
                //그 오브젝트를 SelectObj에 놓는다 //터치하고 있는다
                SelectedObj = hitobj.collider.gameObject;
                Touched = true;
                Destroy(SelectedObj);
                //}
            }
        }
        //터치가 끝나면 터치 끝.
        if (touch.phase == TouchPhase.Ended)
        {
            Touched = false;
        }

        if (raycastMgr.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            textUI.text = "raycast2";
            //터치 시 해당 오브젝트 삭제
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

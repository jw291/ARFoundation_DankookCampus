using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ROTCClickEvent : MonoBehaviour
{

    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer ROTCRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text ROTCName;
    public Text ROTCAddress;
    void Start()
    {
        PMS = GameObject.Find("PanelAnimationManager").GetComponent<Panel_ManagerScript>();
        targetbuildingLocation = GameObject.Find("NavTargetLocation").GetComponent<TargetbuildingLocation>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "ROTCbuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.318837f, 127.131406f);
                    ROTCName.text = "학군단";
                    ROTCAddress.text = "경기도 용인시 수지구 죽전동 126";
                    Animator.Play("Slide In");
                    //hit.collider.gameObject.GetComponent<Renderer>().material = highlightMaterial;
                    Debug.Log("학군단 클릭!");

                }
                else
                {
                    //Animator.Play("Slide Out");
                    PMS.EnableBoolAnimator(Animator);
                    //hit.collider.gameObject.GetComponent<Renderer>().material = DefaultMaterial;
                    Debug.Log("학군단이 아니다");
                }
            }
        }
    }
}
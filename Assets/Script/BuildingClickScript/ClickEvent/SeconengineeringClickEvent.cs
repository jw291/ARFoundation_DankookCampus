using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SeconengineeringClickEvent : MonoBehaviour
{
    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;

    [Header("패널에 빌딩정보 넣기")]
    public Text SEName;
    public Text SEAddress;
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
                if (hit.transform.name == "2engineeringbuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.321014F, 127.125899F);//37.321004,127.125988
                    SEName.text = "제2 공학관";
                    SEAddress.text = "경기도 용인시 수지구 죽전로 152(죽전동)";
                    Animator.Play("Slide In");
                }
                else
                {
                    PMS.EnableBoolAnimator(Animator);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThirdengineeringClickEvent : MonoBehaviour
{

    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer ThirdengineeringRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text ThirdengineeringName;
    public Text ThirdengineeringAddress;
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
                if (hit.transform.name == "3engineeringbuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.320192f, 127.126766f);
                    ThirdengineeringName.text = "제3 공학관";
                    ThirdengineeringAddress.text = "경기도 용인시 수지구 죽전동 126";
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

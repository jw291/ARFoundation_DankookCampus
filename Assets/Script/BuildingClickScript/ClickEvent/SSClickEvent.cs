using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SSClickEvent : MonoBehaviour
{
    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer SocietyScienceRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text SocietyScienceName;
    public Text SocietyScienceAddress;
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
                if (hit.transform.name == "SocietySciencebuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.321282f, 127.125413f);
                    SocietyScienceName.text = "사회과학관";
                    SocietyScienceAddress.text = "경기도 용인시 수지구 죽전동 126";
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

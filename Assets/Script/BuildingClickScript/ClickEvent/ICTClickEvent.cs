using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ICTClickEvent : MonoBehaviour
{

    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer ICTRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text ICTName;
    public Text ICTAddress;
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
                if (hit.transform.name == "ICTbuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.322739f, 127.127666f);
                    ICTName.text = "ICT관";
                    ICTAddress.text = "경기도 용인시 수지구 죽전동 126";
                    Animator.Play("Slide In");
                    //hit.collider.gameObject.GetComponent<Renderer>().material = highlightMaterial;
                    Debug.Log("ICT관 클릭!");

                }
                else
                {
                    //Animator.Play("Slide Out");
                    PMS.EnableBoolAnimator(Animator);
                    //hit.collider.gameObject.GetComponent<Renderer>().material = DefaultMaterial;
                    Debug.Log("ICT관이 아니다");
                }
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InmunClickEvent : MonoBehaviour
{

    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer inmunRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text inmunName;
    public Text inmunAddress;
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
                if (hit.transform.name == "inmunbuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.321748f, 127.129083f);
                    inmunName.text = "인문관";
                    inmunAddress.text = "경기도 용인시 수지구 죽전동 126";
                    Animator.Play("Slide In");
                    //hit.collider.gameObject.GetComponent<Renderer>().material = highlightMaterial;
                    Debug.Log("인문관 클릭!");

                }
                else
                {
                    //Animator.Play("Slide Out");
                    PMS.EnableBoolAnimator(Animator);
                    //hit.collider.gameObject.GetComponent<Renderer>().material = DefaultMaterial;
                    Debug.Log("인문관이 아니다");
                }
            }
        }
    }
}
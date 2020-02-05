using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LibraryClickEvent : MonoBehaviour {

    private TargetbuildingLocation targetbuildingLocation;
    private Panel_ManagerScript PMS;
    public Animator Animator;
    public static Renderer LibraryRender;
    [Header("패널에 빌딩정보 넣기")]
    public Text LibraryName;
    public Text LibraryAddress;
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
                if (hit.transform.name == "Librarybuilding")
                {
                    targetbuildingLocation.getTargetLocation(37.321189f, 127.1274111f);
                    LibraryName.text = "퇴계기념중앙도서관";
                    LibraryAddress.text = "경기도 용인시 수지구 죽전동 126";
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

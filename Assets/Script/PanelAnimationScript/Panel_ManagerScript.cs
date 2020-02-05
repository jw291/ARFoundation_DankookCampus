using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Panel_ManagerScript : MonoBehaviour
{
    public void DisableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", false);
    }

    public void EnableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void MoreDetailDisableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", false);
        var clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }
    public void MoreDetailEnableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void RoadEnableBoolAnimator(GameObject GO)
    {
        //GameObject ARCameraObject = GameObject.Find("ARCamera");
        //GameObject Arrow = Instantiate(GO) as GameObject;
        //Arrow.SetActive(true);
        //Arrow.transform.parent = ARCameraObject.transform;
        //Arrow.transform.localPosition = new Vector3(-3,-15,314);
        GO.SetActive(true);
    }

    public void RoadDisableBoolAnimator(GameObject GO)
    {/*
        var ArrowTag = GameObject.FindGameObjectsWithTag("Arrow");
        foreach (var arrowtag in ArrowTag)
        {

            Destroy(arrowtag);
        }
        */
        GO.SetActive(false);
    }
}

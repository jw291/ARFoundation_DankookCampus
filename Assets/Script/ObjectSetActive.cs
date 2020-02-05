using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetActive : MonoBehaviour
{
    public GameObject CameraButton;
    public GameObject ReCameraButton;
    public GameObject HomeButton;
    // Start is called before the first frame update
    public void ReBtnSetActiveT()
    {
        ReCameraButton.SetActive(true);
    }
    public void ReBtnSetActiveF()
    {
        ReCameraButton.SetActive(false);
    }
    public void CaBtnSetActiveT()
    {
        CameraButton.SetActive(true);
    }
    public void CaBtnSetActiveF()
    {
        CameraButton.SetActive(false);
    }
    public void HomeBtnSetActiveT()
    {
        HomeButton.SetActive(true);
    }
    public void HomeBtnSetActiveF()
    {
        HomeButton.SetActive(false);
    }
}

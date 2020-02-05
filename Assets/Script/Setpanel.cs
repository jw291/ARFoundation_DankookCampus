using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setpanel : MonoBehaviour
{
    public GameObject img;

    public void SetFadeImage()
    {
        img.SetActive(false);
        img.SetActive(true);
    }

    public void GetFadeImage()
    {
        img.SetActive(true);
    }
}

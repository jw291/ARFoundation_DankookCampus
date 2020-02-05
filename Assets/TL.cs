using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TL : MonoBehaviour
{
    public Text latitude;
    public Text longitude;
    // Update is called once per frame
    void Update()
    {
        latitude.text = ""+TargetbuildingLocation.targetbuildinglatitude;
        longitude.text = ""+TargetbuildingLocation.targetbuildinglongitude;

    }
}

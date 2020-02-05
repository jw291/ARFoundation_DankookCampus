using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetbuildingLocation : MonoBehaviour
{
    public static float targetbuildinglatitude;
    public static float targetbuildinglongitude;
    // Start is called before the first frame update
    public void getTargetLocation(float latitude, float longitude)
    {
        targetbuildinglatitude = latitude;
        targetbuildinglongitude = longitude;
    }
}

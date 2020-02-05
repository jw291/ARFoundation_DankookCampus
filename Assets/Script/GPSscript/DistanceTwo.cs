using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DistanceTwo : MonoBehaviour
{
    private float cLat, cLong, tLat, tLong;
    public static float Distance;

    // Use this for initialization
    void Start()
    {
        cLat = GPS.latitude;
        cLong = GPS.longitude;
        tLat = TargetbuildingLocation.targetbuildinglatitude;
        tLong = TargetbuildingLocation.targetbuildinglongitude;
    }

    // Update is called once per frame
    void Update()
    {
        cLat = GPS.latitude;
        cLong = GPS.longitude;
        tLat = TargetbuildingLocation.targetbuildinglatitude;
        tLong = TargetbuildingLocation.targetbuildinglongitude;
        Distance = distanceInMetersBetweenEarthCoordinates(cLat, cLong, tLat, tLong);
    }
    /*
    public float Distance(float cLat, float cLong, float tLat, float tLong)
    {
        float theta, dist;
        theta = cLong - tLong;

        dist = Math.S
    }*/
    private float degreesToRadians(float degrees)
    {
        return degrees * Mathf.PI / 180;
    }

    private float distanceInMetersBetweenEarthCoordinates(float cLat, float cLon, float tLat, float tLon)
    {
        var earthRadiusKm = 6371;

        var dLat = degreesToRadians(tLat - cLat);
        var dLon = degreesToRadians(tLon - cLon);

        cLat = degreesToRadians(cLat);
        tLat = degreesToRadians(tLat);

        var a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
                Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2) * Mathf.Cos(cLat) * Mathf.Cos(tLat);
        var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return earthRadiusKm * c / 1000;
    }
}

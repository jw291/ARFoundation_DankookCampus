using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class distance : MonoBehaviour {

    private float cLat, cLong, tLat, tLong;
    public static double Distance;

	// Use this for initialization
	void Start () {

        cLat = GPS.latitude;
        cLong = GPS.longitude;
        tLat = TargetbuildingLocation.targetbuildinglatitude;
        tLong = TargetbuildingLocation.targetbuildinglongitude;


	}
	
	// Update is called once per frame
	void Update () {

        cLat = GPS.latitude;
        cLong = GPS.longitude;
        tLat = TargetbuildingLocation.targetbuildinglatitude;
        tLong = TargetbuildingLocation.targetbuildinglongitude;
        Distance = Math.Truncate(calDistance(cLat,cLong,tLat,tLong)*1000)/1000;
    }

    /*
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
    */

    public double calDistance(double lat1, double lon1, double lat2, double lon2)
    {

        double theta, dist;
        theta = lon1 - lon2;
        dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1))
              * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
        dist = Math.Acos(dist);
        dist = rad2deg(dist);

        dist = dist * 60 * 1.1515;
        dist = dist * 1.609344;    // 단위 mile 에서 km 변환.  
        dist = dist * 1000.0;      // 단위  km 에서 m 로 변환  

        return dist;
    }

    // 주어진 도(degree) 값을 라디언으로 변환  
    private double deg2rad(double deg)
    {
        return (double)(deg * Math.PI / (double)180d);
    }

    // 주어진 라디언(radian) 값을 도(degree) 값으로 변환  
    private double rad2deg(double rad)
    {
        return (double)(rad * (double)180d / Math.PI);
    }

}


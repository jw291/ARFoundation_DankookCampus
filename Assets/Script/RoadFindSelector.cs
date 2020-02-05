using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoadFindSelector : MonoBehaviour
{
    private TargetbuildingLocation targetbuildingLocation;
    private Text BuildingName;
    // Start is called before the first frame update
    void Start()
    {
        targetbuildingLocation = GameObject.Find("NavTargetLocation").GetComponent<TargetbuildingLocation>();
        BuildingName = GameObject.Find("buildingname").GetComponent<Text>();
    }

    public void Select()
    {
        string BN = BuildingName.text;
        switch (BN)
        {
            case "퇴계기념중앙도서관": Debug.Log("퇴계기념중앙도서관 GPS"); targetbuildingLocation.getTargetLocation(37.321189f, 127.1274111f); break;
            case "제1 공학관": Debug.Log("제1 공학관 GPS"); targetbuildingLocation.getTargetLocation(37.321014F, 127.125899F); break;
        }
    }
}

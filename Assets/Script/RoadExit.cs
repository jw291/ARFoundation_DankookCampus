using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadExit : MonoBehaviour
{
    public GameObject go;
    public void RoadOn()
    {
        go.SetActive(true);
    }

    public void RoadOff()
    {
        go.SetActive(false);
    }

}

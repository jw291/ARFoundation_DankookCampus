using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textMang : MonoBehaviour {

    public Text dist;
    
    // Update is called once per frame
    private void Update()
    {
        dist.text = "남은거리(m): " + distance.Distance.ToString();
    }
}

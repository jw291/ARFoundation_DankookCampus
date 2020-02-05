using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WestHighLight : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material DefaultMaterial;
    public static Renderer Westobject;
    void Start()
    {
        Westobject = gameObject.GetComponent<Renderer>();
        // targetbuildingLocation = GameObject.Find("NavTargetLocation").GetComponent<TargetbuildingLocation>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Westbuilding")
                {
                    Westobject.material = highlightMaterial;
                }
                else
                    Westobject.material = DefaultMaterial;
            }
        }

    }


}

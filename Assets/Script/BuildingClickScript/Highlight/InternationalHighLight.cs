using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InternationalHighLight : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material DefaultMaterial;
    public static Renderer Interobject;
    void Start()
    {
        Interobject = gameObject.GetComponent<Renderer>();
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
                if (hit.transform.name == "Internationalbuilding")
                {
                    Interobject.material = highlightMaterial;
                }
                else
                    Interobject.material = DefaultMaterial;
            }
        }

    }


}

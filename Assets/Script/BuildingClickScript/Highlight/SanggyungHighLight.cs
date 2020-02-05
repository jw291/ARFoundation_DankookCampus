using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SanggyungHighLight : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material DefaultMaterial;
    public static Renderer Sanggyungobject;
    void Start()
    {
        Sanggyungobject = gameObject.GetComponent<Renderer>();
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
                if (hit.transform.name == "Sanggyungbuilding")
                {
                    Sanggyungobject.material = highlightMaterial;
                }
                else
                    Sanggyungobject.material = DefaultMaterial;
            }
        }

    }


}

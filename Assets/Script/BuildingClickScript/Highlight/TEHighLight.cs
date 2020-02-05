using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TEHighLight : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material DefaultMaterial;
    public static Renderer TEobject;
    void Start()
    {
        TEobject = gameObject.GetComponent<Renderer>();
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
                if (hit.transform.name == "3engineeringbuilding")
                {
                    TEobject.material = highlightMaterial;
                }
                else
                    TEobject.material = DefaultMaterial;
            }
        }

    }


}

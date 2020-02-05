using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class TutorialFoundation : MonoBehaviour
{
    private GameObject instantiateGo;
    public GameObject objectToPlace;
    public GameObject placementIndicator;
    public GameObject Tutorial;
    public GameObject Tutorial2;
    private TypeWriterEffect TypeGo;
    public Transform Type;

    private ARSessionOrigin arOrigin;
    private Pose placementPose;
    private bool placementPoseIsValid = false;

    void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        TypeGo = Type.GetComponent<TypeWriterEffect>();


    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();
        if (instantiateGo == null)
        {
            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                instantiateGo = Instantiate(objectToPlace, placementPose.position, placementPose.rotation) as GameObject;
                TypeGo.StartTyping();

            }
        }
        else
        {
            Tutorial2.SetActive(false);
        }
    }

    private void UpdatePlacementIndicator()
    {
        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            Tutorial.SetActive(false);
            Tutorial2.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        //arOrigin.GetComponent<ARRaycastManager>().Raycast(screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        arOrigin.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;

public class ARTapToPlacePortal : MonoBehaviour
{
    /*
      CREDIT:
      "Getting Started With ARFoundation in Unity (ARKit, ARCore)" tutorial by The Unity Workbench!
      This script casts a ray from the center of the screen to determine if there's
      a real-world surface for the portal to spawn on. If so, the placement mat
      will appear. If not, it'll be hidden.

    */

    public GameObject placementIcon;
    public GameObject portal;

    ARSessionOrigin arOrigin;
    Pose placementPose;
    bool planeDetected;

    // Start is called before the first frame update
    void Start()
    {
      arOrigin = FindObjectOfType<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
      UpdatePlacementPose();
      UpdatePlacementIcon();

      // if a plane is detected AND at least 1 finger has juuust touched the screen (sort of like GetKeyDown)
      if (planeDetected && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
      {
        Instantiate(portal, placementPose.position, placementPose.rotation);
        placementIcon.SetActive(false);
        this.enabled = false;
      }
    }

    void UpdatePlacementPose()
    {
      var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
      var hits = new List<ARRaycastHit>();
      arOrigin.Raycast(screenCenter, hits, TrackableType.Planes);

      planeDetected = hits.Count > 0;

      if (planeDetected)
      {
        placementPose = hits[0].pose;

        // mini tweak to rotate the icon as we rotate the phone:
        var cameraForward = Camera.current.transform.forward;
        var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
        placementPose.rotation = Quaternion.LookRotation(cameraBearing);
      }
    }

    void UpdatePlacementIcon()
    {
      if (planeDetected)
      {
        placementIcon.SetActive(true);
        placementIcon.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
      }
      else
      {
        placementIcon.SetActive(false);
      }
    }
}

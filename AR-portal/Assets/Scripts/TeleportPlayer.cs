using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TeleportPlayer : MonoBehaviour
{
    public Material skybox;
    ARCameraBackground arCameraBackgroundScript;

    void Start()
    {
      // the ARCamera game object comes with a script that sets the background as the phone's camera feed.
      // we can override this and make it render the skybox material instead.
      arCameraBackgroundScript = Camera.main.GetComponent<ARCameraBackground>();
    }

    void OnTriggerEnter (Collider other)
    {
      if (other.tag == "MainCamera")
      {
        // reveal otherworld's sky
        arCameraBackgroundScript.useCustomMaterial = true;
        arCameraBackgroundScript.customMaterial = skybox;

        // allow ARcamera to see otherworld layer. this is layer 10, or 1<<10.
        // total layers visible are (1<<5) | (1<<9) | (1<<10)
        // CAMERA.cullingMask |= (1<<10) to add, CAMERA.cullingMask &= ~(1<<10) to remove?, CAMERA.cullingMask ^= (1<<10) to toggle

        // Camera.main.cullingMask |= (1 << 10);
        // let's get the skybox working first, then uncomment
      }
    }

}

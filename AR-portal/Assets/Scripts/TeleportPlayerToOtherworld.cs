using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Audio;

public class TeleportPlayerToOtherworld : MonoBehaviour
{
    ARCameraBackground arCameraBackgroundScript;

    public AudioMixer mixer;
    AudioMixerSnapshot after;

    void Start()
    {
        // the ARCamera game object comes with a script that sets the background as the phone's camera feed.
        // we can disable this to disable our skybox instead.
        arCameraBackgroundScript = Camera.main.GetComponent<ARCameraBackground>();

        after = mixer.FindSnapshot("After");
    }

    void OnTriggerEnter (Collider other)
    {
      if (other.tag == "MainCamera")
      {
            // reveal otherworld's sky
            arCameraBackgroundScript.enabled = false;

            // allow ARcamera to see layer 10: otherworld
            Camera.main.cullingMask |= (1 << 10);

            // transition between audio states (sounds like breaking the surface of a pool)
            after.TransitionTo(.2f);

            // my notes:
            // total layers visible are (1<<5) | (1<<9) | (1<<10)
            // CAMERA.cullingMask |= (1<<10) to add, CAMERA.cullingMask &= ~(1<<10) to remove?, CAMERA.cullingMask ^= (1<<10) to toggle
      }
    }

}

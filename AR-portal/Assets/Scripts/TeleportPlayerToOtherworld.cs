using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Audio;

public class TeleportPlayerToOtherworld : MonoBehaviour
{
    ARCameraBackground arCameraBackgroundScript;

    GameObject exit;

    public AudioMixer mixer;
    AudioMixerSnapshot after;

    void Start()
    {
        // the ARCamera game object comes with a script that sets the background as the phone's camera feed.
        // we can disable this to disable our skybox instead.
        arCameraBackgroundScript = Camera.main.GetComponent<ARCameraBackground>();

        exit = transform.parent.GetChild(3).gameObject;

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
      }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            exit.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}

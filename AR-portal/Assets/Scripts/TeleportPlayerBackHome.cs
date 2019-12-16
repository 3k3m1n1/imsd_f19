using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Audio;

public class TeleportPlayerBackHome : MonoBehaviour
{
    ARCameraBackground arCameraBackgroundScript;

    GameObject entrance;

    public AudioMixer mixer;
    AudioMixerSnapshot before;

    void Start()
    {
        // the ARCamera game object comes with a script that sets the background as the phone's camera feed.
        arCameraBackgroundScript = Camera.main.GetComponent<ARCameraBackground>();

        entrance = transform.parent.GetChild(1).gameObject;

        before = mixer.FindSnapshot("Before");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            // hide skybox
            arCameraBackgroundScript.enabled = true;

            // remove layer 10 (otherworld) from ARCamera view
            Camera.main.cullingMask &= ~(1 << 10);

            // switch audio states again
            before.TransitionTo(.2f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            entrance.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}

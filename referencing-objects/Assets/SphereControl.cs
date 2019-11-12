using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    int i;
    public GameObject[] spheres;
    public GameObject audioManager;

    void Update()
    {
        for (i = 0; i < 5; i++) {
          // float multiple spheres up and down
          spheres[i].transform.position = new Vector3(spheres[i].transform.position.x, Mathf.Sin(Time.time), 0);
        }

        // check to see if key has been pressed
        IfSpacePlaySound();

    }

    void IfSpacePlaySound() {
      if (Input.GetKeyDown(KeyCode.Space)) {
        // grab the audio source from another object
        AudioSource source = audioManager.GetComponent<AudioSource>();
        source.Play();
      }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTonTrigger : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
      if (other.tag == "Player")
      {
        // reveal otherworld's sky
        Camera.main.clearFlags = CameraClearFlags.Skybox;

        // allow ARcamera to see layer 10: otherworld
        Camera.main.cullingMask |= (1 << 10);

        // my notes:
        // total layers visible are (1<<5) | (1<<9) | (1<<10)
        // CAMERA.cullingMask |= (1<<10) to add, CAMERA.cullingMask &= ~(1<<10) to remove?, CAMERA.cullingMask ^= (1<<10) to toggle
      }
    }
}

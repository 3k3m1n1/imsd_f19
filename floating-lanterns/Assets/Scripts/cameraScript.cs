using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    // VARIABLES
    float yaw;
    float pitch;

    // Update is called once per frame
    void Update()
    {
        yaw += 2.2f * Input.GetAxis("Mouse X");
        pitch -= 2.2f * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}

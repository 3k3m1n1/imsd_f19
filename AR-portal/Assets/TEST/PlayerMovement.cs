using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float yaw;
    float pitch;

    // Start is called before the first frame update
    // void Start()
    // {
    //
    // }

    // Update is called once per frame
    void Update()
    {
      yaw += Input.GetAxis("Mouse X") * 3f;
      pitch -= Input.GetAxis("Mouse Y") * 3f;
      transform.eulerAngles = new Vector3(pitch, yaw, 0f);

      if (Input.GetKey(KeyCode.A))
      {
        transform.position += Vector3.left * Time.deltaTime * 2f;
      }

      if (Input.GetKey(KeyCode.D))
      {
        transform.position += Vector3.right * Time.deltaTime * 2f;
      }

      if (Input.GetKey(KeyCode.W))
      {
        transform.position += Vector3.forward * Time.deltaTime * 2f;
      }

      if (Input.GetKey(KeyCode.S))
      {
        transform.position += Vector3.back * Time.deltaTime * 2f;
      }
    }
}

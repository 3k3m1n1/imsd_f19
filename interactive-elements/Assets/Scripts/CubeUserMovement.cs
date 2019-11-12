using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUserMovement : MonoBehaviour
{
    public float moveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // float upward
        {
            transform.position += new Vector3(0, 1 * moveSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S)) // float downward
        {
            transform.position += new Vector3(0, -1 * moveSpeed * Time.deltaTime, 0);
        }
    }
}

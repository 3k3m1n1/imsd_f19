using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleUserMovement : MonoBehaviour
{
    public float moveSpeed = 2;
    public float cartwheelSpeed = 700;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) // cartwheel to the left
        {
            transform.Rotate(0, 0, cartwheelSpeed * Time.deltaTime);
            transform.position += new Vector3(-1 * moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D)) // cartwheel to the right
        {
            transform.Rotate(0, 0, -cartwheelSpeed * Time.deltaTime);
            transform.position += new Vector3(1 * moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5 * Mathf.Sin(Time.time), 5 * Mathf.Cos(Time.time), transform.position.z);
    }
}

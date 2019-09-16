using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SlomoElevator();
    }

    void SlomoElevator()
    {
        transform.position = new Vector3(transform.position.x, 2 * Mathf.Tan(Time.time), transform.position.z);
    }
}

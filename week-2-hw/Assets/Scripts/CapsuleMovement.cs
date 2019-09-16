using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float cartwheelSpeed = -700;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NeverEndingCartwheel();
    }

    void NeverEndingCartwheel()
    {
        transform.Rotate(0, 0, cartwheelSpeed * Time.deltaTime);
        transform.position += Vector3.right * Time.deltaTime;
    }
}

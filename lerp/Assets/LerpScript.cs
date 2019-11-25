using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    float timer = 0f;
    Vector3 start = new Vector3(-5f, 0f, 0f);
    Vector3 end = new Vector3(0f, 0f, -5f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.PingPong(Time.time, 1f);

        // transform.position = (end - start) * timer + start;
        // or
        transform.position = Vector3.Lerp(start, end, timer);
    }
}

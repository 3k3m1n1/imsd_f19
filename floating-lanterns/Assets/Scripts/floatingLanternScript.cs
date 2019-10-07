using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingLanternScript : MonoBehaviour
{
    // VARIABLES
    Vector3 startPos;
    float offset;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        offset = Time.time;
        speed = Random.Range(0.4f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + new Vector3(0.0f, speed * Mathf.Sin(Time.time - offset), 0.0f);
    }
}

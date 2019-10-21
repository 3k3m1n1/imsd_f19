using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
    float timer;
    public GameObject lightObject;
    Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f) {
          lightComponent = lightObject.GetComponent<Light>();
          lightComponent.color = new Color( ( Mathf.Sin(Time.time) / 2) + 0.5f, lightComponent.color.g, lightComponent.color.b, lightComponent.color.a);
        }
    }
}

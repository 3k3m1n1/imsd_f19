using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    bool is1Growing = true;
    bool is2Growing = true;
    bool is3Growing = true;

    public GameObject prefab;
    Transform[] spheres = new Transform[8];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject g = Instantiate(prefab, new Vector3(2*i, 0f, 0f), Quaternion.identity);
            spheres[i] = g.transform;
        }
    }


    // Update is called once per frame
    void Update()
    {
        ToggleChangeInSize(KeyCode.Q, spheres[0], is1Growing);
        ToggleChangeInSize(KeyCode.W, spheres[1], is2Growing);
        ToggleChangeInSize(KeyCode.E, spheres[2], is3Growing);
    }

    void ToggleChangeInSize(KeyCode key, Transform sphere, bool isGrowing)
    {
        if (Input.GetKey(key))
        {
            isGrowing = !isGrowing;
        }

        if (!isGrowing)
            sphere.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
        else
            if (sphere.localScale.x > 1)
                sphere.localScale -= new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESThideQuad : MonoBehaviour
{
    public GameObject quad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
          if (quad.activeSelf)
          {
            quad.SetActive(false);
          }
          else
          {
            quad.SetActive(true);
          }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPortalCamera : MonoBehaviour
{
    Transform player;
    Transform portal;
    public bool checkbox;

    // Start is called before the first frame update
    void Start()
    {
      // the player's transform is tracked by the AR Camera game object, which is tagged as our Main Camera.
      player = Camera.main.transform;
      portal = transform.parent.GetChild(0); // portal's actual position (quad)
    }

    // Update is called once per frame
    void Update()
    {
      // portal camera moves according to the player's position in order to simulate perspective.
      Vector3 offset = portal.position - player.position;
      transform.position = portal.position + offset;

      // rotation?
      if (checkbox)
      {
        transform.rotation = Quaternion.LookRotation(portal.position - player.position); // this is wrong
      }

    }
}

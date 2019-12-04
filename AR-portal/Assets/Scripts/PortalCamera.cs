using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    Transform player;
    Transform portal;

    void Start()
    {
      // the player's transform is tracked by the AR Camera game object, which is tagged as our Main Camera.
      player = Camera.main.transform;
      portal = transform; // the "portal" parent gameobject is actually 2 units below the camera/quad, so we'll save the camera's initial position instead
    }

    void Update()
    {
      // portal camera moves according to the player's position in order to simulate perspective.
      Vector3 offset = portal.position - player.position;
      transform.position = portal.position + offset;
    }
}

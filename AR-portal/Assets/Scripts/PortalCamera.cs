using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    Transform player;
    public Transform portal;

    void Start()
    {
      // the player's transform is tracked by the AR Camera game object, which is tagged as our Main Camera.
      player = Camera.main.transform;
    }

    void Update()
    {
      // portal camera's position mirrors the player's position in order to simulate perspective.
      Vector3 playerOffsetFromPortal = player.position - portal.position;
      transform.position = portal.position + playerOffsetFromPortal;

      // maps player rotation to portal camera
      transform.rotation = player.rotation;
    }
}

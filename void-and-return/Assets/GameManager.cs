using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] allSpheresInScene;

    void Start()
    {
      allSpheresInScene = GameObject.FindGameObjectsWithTag("Sphere");
    }

    void Update()
    {
      // plug each game object in array into void function
      for (int i = 0; i < allSpheresInScene.Length; i++) {
        MoveThis(allSpheresInScene[i]);
      }
    }

    void MoveThis(GameObject myObject)
    {
      myObject.transform.position += new Vector3(1/SizeOfObject(myObject) * Time.deltaTime, transform.position.y, 0f);
    }

    float SizeOfObject(GameObject a) // might have to change this var name
    {
      float size = a.transform.localScale.x;
      return size;
    }
}

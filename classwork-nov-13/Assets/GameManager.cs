using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] cubes = new GameObject[8];
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            cubes[i] = Instantiate(prefab, new Vector3(2*i, 0f, 0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if statement function (void)
        OnKeyPressLiftThisCube(0, KeyCode.A);
        OnKeyPressLiftThisCube(1, KeyCode.S);
        OnKeyPressLiftThisCube(2, KeyCode.D);
        OnKeyPressLiftThisCube(3, KeyCode.F);
        OnKeyPressLiftThisCube(4, KeyCode.J);
        OnKeyPressLiftThisCube(5, KeyCode.K);
        OnKeyPressLiftThisCube(6, KeyCode.L);
        OnKeyPressLiftThisCube(7, KeyCode.Semicolon);
    }

    void OnKeyPressLiftThisCube(int whichCube, KeyCode key)
    {
        if (Input.GetKey(key))
            cubes[whichCube].transform.position += Vector3.up * Time.deltaTime;
        else
        {
            if (cubes[whichCube].transform.position.y >= 0)
            {
                cubes[whichCube].transform.position += Vector3.down * Time.deltaTime;
            }
        }
    }
}

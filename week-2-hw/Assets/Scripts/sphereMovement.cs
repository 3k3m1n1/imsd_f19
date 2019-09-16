using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{

    int wholeNumber;
    float decimalNumber;
    Vector3 threeFloats;

    int randomYPositionUpOrDown;

    void Start()
    {
        wholeNumber = 4;
        decimalNumber = 4.021f;
        threeFloats = new Vector3(2.0f, 1.0f, 3.333f);
        threeFloats.y = 4.23f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheSphereTopOrBottomOfScreen();
        MoveTheSphereDeeperIntoTheScreen();
    }

    void MoveTheSphereTopOrBottomOfScreen()
    {
        randomYPositionUpOrDown = Random.Range(0, 2);
        transform.position = new Vector3(transform.position.x, -10 + 20 * randomYPositionUpOrDown, transform.position.z);
    }

    void MoveTheSphereDeeperIntoTheScreen()
    {
        transform.position = transform.position + Vector3.forward * Time.deltaTime * 10;
    }
}
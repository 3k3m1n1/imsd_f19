using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUniqueMovement : MonoBehaviour
{
    int randomPositionThatIsEitherLeftOrRight;
    int randomPositionThatIsEitherupOrDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomPositionThatIsEitherLeftOrRight = Random.Range(-5, 5);
        randomPositionThatIsEitherupOrDown = Random.Range(0, 2);
        transform.position = new Vector3(-10 + 20 * randomPositionThatIsEitherLeftOrRight, randomPositionThatIsEitherupOrDown, transform.position.z);
        transform.position += Vector3.back * Time.deltaTime;
    }
}

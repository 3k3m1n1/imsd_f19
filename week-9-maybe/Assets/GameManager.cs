using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] blockTypes;
    GameObject currentBlock;
    float timer;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
      SpawnRandomBlock();
    }

    // Update is called once per frame
    void Update()
    {
      // USER MOVEMENT
      if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        // move block one unit to the left
        currentBlock.transform.position += Vector3.left;
      }
      if (Input.GetKeyDown(KeyCode.RightArrow)) {
        // move block one unit to the right
        currentBlock.transform.position += Vector3.right;
      }
      if (Input.GetKeyDown(KeyCode.Z)) {
        // rotate 90º counterclockwise
        currentBlock.transform.Rotate(0f, 0f, 90f);
      }
      if (Input.GetKeyDown(KeyCode.X)) {
        // rotate 90º clockwise
        currentBlock.transform.Rotate(0f, 0f, -90f);
      }

      // AUTOMATIC MOVEMENT
      if (timer >= 1f) {
        // if the block has not reached the bottom of the map
        if (currentBlock.transform.position.y > -8f) {
          currentBlock.transform.position += Vector3.down; // move block down in 1sec ticks
          timer = 0f; // reset timer, so we can start counting again
        } else {
          // the block is now at the bottom. spawn a new one
          SpawnRandomBlock();
        }
      }
      timer += Time.deltaTime;
    }

    void SpawnRandomBlock() {
      rand = Random.Range(0, blockTypes.Length - 1);
      currentBlock = Instantiate(blockTypes[rand], new Vector3(0, 8, 0), Quaternion.identity);
    }
}

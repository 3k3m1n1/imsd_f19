using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    public GameObject brick;

    // Start is called before the first frame update
    void Start()
    {
        backWallBuilder(-10, 10, 5);
        sidesWallBuilder(-5, 5, -10);
        sidesWallBuilder(-5, 5, 10);
        floorCeilingBuilder(-10, 10, -1);
        floorCeilingBuilder(-10, 10, 10);
    }

    void backWallBuilder(int whereToStartWallAlongX, int whereToEndWallAlongX, int zOffset)
    {
        for (int lengthOfWall = whereToStartWallAlongX; lengthOfWall <= whereToEndWallAlongX; lengthOfWall++)
        {
            for (int heightOfWall = 0; heightOfWall < 10; heightOfWall++)
            {
                Instantiate(brick, new Vector3(lengthOfWall, heightOfWall, zOffset), Quaternion.identity);
            }
        }
    }

    void sidesWallBuilder(int whereToStartWallAlongZ, int whereToEndWallAlongZ, int xOffset)
    {
        for (int lengthOfWall = whereToStartWallAlongZ; lengthOfWall <= whereToEndWallAlongZ; lengthOfWall++)
        {
            for (int heightOfWall = 0; heightOfWall < 10; heightOfWall++)
            {
                Instantiate(brick, new Vector3(xOffset, heightOfWall, lengthOfWall), Quaternion.identity);
            }
        }
    }

    void floorCeilingBuilder(int whereToStartWallAlongX, int whereToEndWallAlongX, int yOffset)
    {
        for (int lengthOfWall = whereToStartWallAlongX; lengthOfWall <= whereToEndWallAlongX; lengthOfWall++)
        {
            for (int widthOfWall = -5; widthOfWall < 5; widthOfWall++)
            {
                Instantiate(brick, new Vector3(lengthOfWall, yOffset, widthOfWall), Quaternion.identity);
            }
        }
    }
}

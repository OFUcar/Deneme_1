using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;

    void Start()
    {
        SpawnObstacles();
    }

    private void SpawnObstacles()
    {
        float StartXPosition = -5f;

        for( int i=0; i < 6; i++)
        {
            float obstacleXPosition = StartXPosition + i * 5f;
            Vector3 spawnObstaclePosition = new Vector3(obstacleXPosition, 0.5f, 0);

            if ( obstacle != null)
            {
                Instantiate(obstacle, spawnObstaclePosition, Quaternion.identity);
            }
            else
            {
                Debug.LogError("Obstacle da sorun var");
            }
        }

    }
}

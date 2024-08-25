using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 50f;

    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private GameObject player;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int startingSpawnLevelParts = 1;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(new Vector3(player.transform.position.x, 0, 0), new Vector3(lastEndPosition.x, 0, 0)) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        // Spawn the new level part at the X position of the last end position, keeping Y and Z the same.
        Vector3 spawnPosition = new Vector3(lastEndPosition.x, levelPart_Start.position.y, levelPart_Start.position.z);
        Transform levelPartTransform = SpawnLevelPart(spawnPosition);
        lastEndPosition = levelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}

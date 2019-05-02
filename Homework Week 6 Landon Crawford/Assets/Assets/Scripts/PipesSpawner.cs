using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public float spawnXPosition;
    public GameObject pipesInstancePrefab;
    public float spawnNewTriggerXPos;

    Transform lastSpawnedPipe;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(pipesInstancePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity);    
    }


    // Update is called once per frame
    void Update()
    {
        if (lastSpawnedPipe == null)
        {
            lastSpawnedPipe = Instantiate(pipesInstancePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
        }
        else
        {
            if (lastSpawnedPipe.position.x < spawnNewTriggerXPos)
            {
                lastSpawnedPipe = Instantiate(pipesInstancePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
            }
        }
    }
}

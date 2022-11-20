using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectables : MonoBehaviour
{
    public GameObject[] collect;
    public GameObject[] spawnPoints;
  // int randomSpawnPoint, randomCollectable;

    // Start is called before the first frame update
    public void Start()
    {
      //randomSpawnPoint = Random.Range(0, spawnPoints.Length);
     // randomCollectable = Random.Range(0, collect.Length);
     // Instantiate (collect[randomCollectable], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
      Instantiate (collect[Random.Range(0, collect.Length)], spawnPoints[spawnPoints.Length].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

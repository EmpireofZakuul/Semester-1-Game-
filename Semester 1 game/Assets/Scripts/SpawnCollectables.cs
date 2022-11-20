using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectables : MonoBehaviour
{
    public GameObject[] collect;
    public Transform[] spawnPoints;
  // int randomSpawnPoint, randomCollectable;

    // Start is called before the first frame update
    public void Start()
    {
      for(int i = 0; i < spawnPoints.Length; i++)
        {
            
            Instantiate(collect[Random.Range(0, collect.Length)], spawnPoints[i].position,transform.rotation);
        }  
     }   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHole : MonoBehaviour {
    //The spawnhole will release an enemy after a timer has count down the starting variable will be public and constant for the 
    //enemies will spawn and will move towards a certain point on the map. once they reach that point they will change target to the objective.
    // once enemies reach objective they will pick up one of 10 objectives and they till target the spawn point with the item and run in a straight line

    public GameObject enemyToSpawn;
    public float currentSpawnTime;
    public float round1SpawnTime;

    public int targetNumberForEnemyToWin;
    public int currentNumOfPointsCollected;


	// the the game the starts the spawn will begin to count down
	void Start () {
        currentSpawnTime = round1SpawnTime;
        


		
	}
	
	// Update is called once per frame
	void Update () {
		SpawnTimer();
        
	}

    void SpawnTimer()
    {
        currentSpawnTime = currentSpawnTime - Time.deltaTime;

        if (currentSpawnTime <= 0.0f)
        {
            SpawnEnemyPrefab();
            currentSpawnTime = round1SpawnTime;
        }
    }

    void SpawnEnemyPrefab()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.GetComponent<EnemyBehaviour>().objectiveReached == true)
        {
            currentNumOfPointsCollected += 1;
        }
    }


}

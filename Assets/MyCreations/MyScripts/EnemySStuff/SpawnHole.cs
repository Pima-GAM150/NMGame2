using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHole : MonoBehaviour {
    //The spawnhole will release an enemy after a timer has count down the starting variable will be public and constant for the 
    //enemies will spawn and will move towards a certain point on the map. once they reach that point they will change target to the objective.
    // once enemies reach objective they will pick up one of 10 objectives and they till target the spawn point with the item and run in a straight line

    public GameObject redAntPrefab;
    public GameObject redSoldierAnt;
    
    public int roundSpawnTime;
    public int numberofEnemiesSpawned;
 


	// the the game the starts the spawn will begin to count down
	void Start () {        
        StartCoroutine(SpawnAfterSeconds(roundSpawnTime));
        
	}

    IEnumerator SpawnAfterSeconds(int roundSpawnTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(roundSpawnTime);
            SpawnEnemyPrefab();

        }
    }    

    void SpawnEnemyPrefab()
    {        

        if (numberofEnemiesSpawned == 5)
        {
            Instantiate(redSoldierAnt, transform.position, transform.rotation);
            numberofEnemiesSpawned = 0;
        }
        else
        {
            Instantiate(redAntPrefab, transform.position, transform.rotation);
            numberofEnemiesSpawned += 1;
        }
    }   


}

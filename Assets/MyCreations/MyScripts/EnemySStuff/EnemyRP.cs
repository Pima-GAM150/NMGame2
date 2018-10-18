using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyRP : MonoBehaviour
{

    
    public int resourcesGathered;
    public GameObject[] resources;
    public GameObject resourcePreFab;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        resourcesGathered = GameManager.singleton.enemyCurrentPoints;
        resources = new GameObject[resourcesGathered];
        int index = 0;
        for (index = 0; index < resourcesGathered; index++)
        {
            resources[index] = resourcePreFab;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
        if (other.GetComponent<EnemyBehaviour>().objectiveReached == true)
        {
            GameManager.singleton.AddEnemyPoints(1);


        }
        FriendlyBehaviour friend = other.GetComponent<FriendlyBehaviour>();
        if (other.gameObject.tag == "FriendlyWorker" )
        {
            GameManager.singleton.SubEnemyPoints(1);
        }
        
    }
    
}


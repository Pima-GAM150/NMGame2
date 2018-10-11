using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyRP : MonoBehaviour
{

    public GameManager manager;

    public int resourcesGathered;
    public GameObject[] resources;
    public GameObject resourcePreFab;

    void Start()
    {
        resourcesGathered = manager.enemyCurrentPoints;
    }

    // Update is called once per frame
    void Update()
    {
        resources = new GameObject[resourcesGathered];
        int index = 0;
        for (index = 0; index < resourcesGathered; index++)
        {
            resources[index] = resourcePreFab;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyBehaviour>().objectiveReached == true)
        {
            resourcesGathered += 1;


        }       
        if (other.gameObject.tag == "FriendlyWorker" )
        {
            resourcesGathered -= 1;
            //other.GetComponent<FriendlyBehaviour>().objectiveReached = true;
        }
        
    }
    
}


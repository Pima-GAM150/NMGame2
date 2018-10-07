using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRP : MonoBehaviour
{

    public GameManager manager;

    public int resourcesGathered;
    public GameObject[] resources;

    void Start()
    {
        resourcesGathered = manager.enemyCurrentPoints;
    }

    // Update is called once per frame
    void Update()
    {
        resources = new GameObject[resourcesGathered];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyBehaviour>().objectiveReached == true )
        {
            resourcesGathered += 1;

        }
        if (other.GetComponent<FriendlyBehaviour>().objectiveReached == false)
        {
            resourcesGathered -= 1;
            other.GetComponent<FriendlyBehaviour>().objectiveReached = true;
        }

    }
}


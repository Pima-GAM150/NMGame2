using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRP : MonoBehaviour
{

    public GameManager manager;

    public GameObject resourcePreFab;
    public int resourcesGathered;
    public GameObject[] resourcePool;

    void Start()
    {
        //resourcesGathered = manager.enemyCurrentPoints;
    }

    // Update is called once per frame
    void Update()
    {
        resourcePool = new GameObject[resourcesGathered];
        int index = 0;
        for (index = 0; index < resourcesGathered; index++)
        {
            resourcePool[index] = resourcePreFab;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FriendlyBehaviour>().objectiveReached == true)
        {
            resourcesGathered += 1;

        }
        if (other.GetComponent<EnemyBehaviour>().targetReached == true)
        {
            resourcesGathered -= 1;
            other.GetComponent<FriendlyBehaviour>().objectiveReached = true;
        }
    }
}

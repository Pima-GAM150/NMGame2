using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRP : MonoBehaviour
{

    public GameManager manager;

    public int resourcesGathered;

    void Start()
    {
        resourcesGathered = manager.enemyCurrentPoints;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FriendlyBehaviour>().objectiveReached == true)
        {
            resourcesGathered += 1;

        }
        if (other.GetComponent<EnemyBehaviour>().objectiveReached == false)
        {
            resourcesGathered -= 1;
            other.GetComponent<FriendlyBehaviour>().objectiveReached = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRP : MonoBehaviour
{
    
    public GameObject resourcePreFab;
    public int resourcesGathered;
    public GameObject[] resourcePool;

    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        resourcesGathered = GameManager.singleton.playerCurrentPoints;
        resourcePool = new GameObject[resourcesGathered];
        int index = 0;
        for (index = 0; index < resourcesGathered; index++)
        {
            resourcePool[index] = resourcePreFab;

        }

    }

    //void makeArrayWithSingletonStats()
    //{
    //    
    //}




    private void OnTriggerEnter(Collider other)
    {
        FriendlyBehaviour friend = other.GetComponent<FriendlyBehaviour>();
        if (friend != null && friend.objectiveReached == true)
        {
            GameManager.singleton.AddPlayerPoints(1);

        }

        EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
        if (enemy != null && enemy.targetReached == true)
        {
            GameManager.singleton.SubPlayerPoints(1);
        }
    }
}

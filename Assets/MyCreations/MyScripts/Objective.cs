using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

    public GameManager player;
    public int numberOfPointsToTake;

    public GameObject[] visualPrefabforEnemyToTake;



	void Start () {
        
	}
	

	void Update () {
        PointCheck();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
        }
    }

    void PointCheck()
    {
        if (numberOfPointsToTake <= 0)
        {
            Destroy(gameObject);
        }
    }

}


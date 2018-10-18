using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NeutralRP : MonoBehaviour {

    
    //the number of resoures in this pile at the start of the game will be about 20 for now
    public int numberOfResoursePoints;

    public GameObject resourcePreFab;
    public GameObject[] resourceObjects;
    public Transform rp;


	void Start () {

        rp = this.gameObject.transform;
        resourceObjects = GameObject.FindGameObjectsWithTag("Resource");

        foreach (GameObject Resource in resourceObjects)
        {
            Instantiate(resourcePreFab, rp.transform.position, rp.transform.rotation);
        }

    }
	
	// Update is called once per frame
	void Update () {
        
        ResourseCheck();
		
	}



    void ResourseCheck()
    {
        numberOfResoursePoints = GameManager.singleton.numOfPointsForVictory;

        resourceObjects = new GameObject[numberOfResoursePoints];
        //int index = 0;
        //for (index = 0; index < numberOfResoursePoints; index++)
        //{
        //    //Instantiate(resourcePreFab, new Vector3(index * 2.0f,0,0), Quaternion.identity);
        //    resourceObjects[index] = resourcePreFab;
           
        //}


        

        //ArrayUtility.Add(ref resourceObjects, resourcePreFab);

        if (numberOfResoursePoints <= 0)
        {
            Destroy(gameObject);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FriendlyWorker" || other.gameObject.tag == "EnemyWorker")
        {
            GameManager.singleton.TakeResources(1);
        }
    }
}


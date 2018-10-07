using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralRP : MonoBehaviour {

    public GameManager manager;
    //the number of resoures in this pile at the start of the game will be about 20 for now
    public int numberOfResoursePoints;

    public GameObject resourcePreFab;
    public GameObject[] resourseObjects;


	void Start () {
        //CreateResourses();
        numberOfResoursePoints = manager.numOfPointsForVictory;
        
	}
	
	// Update is called once per frame
	void Update () {
        ResourseCheck();
		
	}

    void CreateResourses()
    {
        Instantiate(resourcePreFab, gameObject.transform.position, gameObject.transform.rotation);
    }



    void ResourseCheck()
    {
        resourseObjects = new GameObject[numberOfResoursePoints];
        //resourseObjects[] = CreateResourses);

        if (numberOfResoursePoints <= 0)
        {
            Destroy(gameObject);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FriendlyWorker" || other.gameObject.tag == "EnemyWorker")
        {
            numberOfResoursePoints -= 1;
        }
    }
}


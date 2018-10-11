using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int playerCurrentPoints;
    public int enemyCurrentPoints;
    public int numOfPointsForVictory = 20;
    public Text victoryBanner;

	
	void Start () {
		
	}
	
	void Update () {
        
        VictoryPointCheck();
	}
     
    void VictoryPointCheck()
    {

        if (enemyCurrentPoints == 20)
        {
            //victoryBanner = "You lose";
        }

        if (playerCurrentPoints == 20)
        {
            //player wins
        }
    }

}

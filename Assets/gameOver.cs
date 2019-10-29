using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        tekst1 = GetComponent<Text>();
        score1 = GameObject.FindObjectOfType<Score>();

	}
    Text tekst1;
    Score score1;
    
    public void GameOver()
    {
        score1.best();
        tekst1.text = "GAME OVER     SCORE:" + Score.punkt + "   BEST:" + Score.best2;

        GetComponent<Text>().enabled = true;
    }
}

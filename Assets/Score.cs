using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();

        punkt = 0;
        //p1 = GameObject.FindObjectOfType<pilka>();
	}
    Text score;
    public static int punkt,best1=0,best2=0;
	// Update is called once per frame
	void Update () {
        score.text = " " + punkt;
	}
    public void best()
    {
        best1 = punkt;
        if (best2 < best1)
            best2 = best1;     
    }
    
}

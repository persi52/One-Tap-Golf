using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blokuj : MonoBehaviour {

	// Use this for initialization
	void Start () {
        pilka = GameObject.FindObjectOfType<pilka>();
        parabola = GameObject.FindObjectOfType<ParabolaGrow>();
    }
    pilka pilka;
    ParabolaGrow parabola;
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        parabola.ButtonPush = false;
        parabola.Test2();
        pilka.lec();
    }
}

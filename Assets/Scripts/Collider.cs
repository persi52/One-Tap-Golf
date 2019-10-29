using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

	// Use this for initialization
	void Start () {
        edge = GetComponent<Collider2D>();
    }
    public Collider2D edge;
	// Update is called once per frame
	void Update () {
		
	}
    public void wylacz()
    {
        edge.enabled = false;
    }
    public void wlacz()
    {
        edge.enabled = true;
    }
}

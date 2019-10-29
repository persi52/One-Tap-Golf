using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
    public Vector2 location;
	// Update is called once per frame
	void Update () {
		
	}
    public void spawner()
    {
        location = new Vector2(Random.Range(-3.5f, 3.6f), 0);
        this.transform.position = location;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParabolaGrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
       startSize = this.transform.localScale;
       startPosition = this.transform.position;   
            

    }
    public bool ButtonPush = false;
    float skala=.004f, x=.01f;
    public static float throw2;
    public GameObject point,point2;
    public static Vector2 throw1,startPosition;
    public Vector3 startSize;
    public GameObject przycisk;


    // Update is called once per frame
    void Update () {

        if(ButtonPush==true)//&& this.transform.localScale.x < 2.7)
        {
            {
                this.transform.localScale += new Vector3(skala, skala, 0);
                this.transform.Translate(x, 0, 0);
            }
        }
       
        
            
    }

    public void Test()
    {
        gameObject.SetActive(true);
        ButtonPush = true;       
        
    }
    public void Test2()
    {

        ButtonPush = false;
        throw1 = point.transform.position;
        throw2 = point2.transform.position.y;
        gameObject.SetActive(false);
                
    }

    public void wartosci()
    {
        skala += 0.002f;
        x += 0.005f;
    }

    public void wracaj()
    {
        this.transform.position = startPosition;
        this.transform.localScale = startSize;
        //gameObject.SetActive(true);
    }
    




}

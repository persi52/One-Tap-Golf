using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilka : MonoBehaviour {

    protected float Animation;
    Vector2 startPosition;
    
    Collider2D m_Collider;


    // Use this for initialization
    void Start () {
        startPosition = this.transform.position;      
        m_Collider = GetComponent<Collider2D>();        
        p1 = GameObject.FindObjectOfType<ParabolaGrow>();
        edge1 = GameObject.FindObjectOfType<Collider>();
        spawner1 = GameObject.FindObjectOfType<Spawn>();
        przycisk = GameObject.Find("Button");
        przycisk2 = GameObject.Find("Button2");
        koniec = GameObject.FindObjectOfType<gameOver>();
        

    }
    public int ziemia = 1;
    public static int punkt = 0;
    
    
    ParabolaGrow p1;
    Collider edge1;
    Spawn spawner1;
    GameObject przycisk,przycisk2,tekst1;
    gameOver koniec;
    
    // Update is called once per frame
    void FixedUpdate () {

        
        if (ziemia == 0 && p1.transform.localScale.x<2.7f)
        {
            Animation += Time.deltaTime;
            Animation = Animation % 5f;
            //if(ParabolaGrow.throw1.x>-6)
            transform.position = MathParabola.Parabola(startPosition, ParabolaGrow.throw1, ParabolaGrow.throw2 + 2, Animation / 1.5f);
            //else
                //transform.position = MathParabola.Parabola(startPosition,new Vector2(-6,0), .3f, Animation / 1.5f);
        }

       
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dołek")
        {
            m_Collider.enabled = false;
            this.transform.position = startPosition;            
            Score.punkt++;
            p1.wartosci();
            Animation = 0;
            spawner1.spawner();
            p1.gameObject.SetActive(true);
            przycisk.gameObject.SetActive(true);
            edge1.wlacz();
        }

        if (other.tag != "Respawn" && other.tag != "Dołek")
        {
            przycisk2.transform.position = new Vector3(125, 65, 0);
            koniec.GameOver();
        }

        Debug.Log(other);
           


        ziemia = 1;       
                
    }

    public void lec()
    {
        
        ziemia = 0;
        p1.wracaj();
        m_Collider.enabled = true;
        edge1.wylacz();
        przycisk.gameObject.SetActive(false);
    }
    public void stoj()
    {
        ziemia = 1;
        Debug.Log(ziemia);
    }
    void animacja()
    {
       
    }
    
}

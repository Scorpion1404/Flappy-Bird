using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public float flapstrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public float birdfall = -15;

    public float birdfly = 15;

   


    // Start is called before the first frame update

    private void Awake() {
        
    }
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){

            myrigidbody.velocity = Vector2.up * flapstrenght;
        }
        
        OutOffBounds();
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        logic.GameOver();
        birdIsAlive=false;
        
    }

    private void OutOffBounds(){

          if(transform.position.y <birdfall){
            logic.GameOver();
            birdIsAlive=false;
           
        }
        if(transform.position.y > birdfly){
            logic.GameOver();
            birdIsAlive=false;
            
        }
    }
}

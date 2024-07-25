using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipe;
    public float Spawnrate = 2;
    private float timer =0;

    public float heightOffSet=10;

    // Start is called before the first frame update
    void Start()
    {
        SwapPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if(timer < Spawnrate){
             timer = timer + Time.deltaTime;

        }
        else{
            SwapPipe();
            timer=0;
        }
        
        
    }
    void SwapPipe(){
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(highestPoint,lowestPoint),0),transform.rotation);

    }
}

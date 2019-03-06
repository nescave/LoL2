using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisController : MonoBehaviour{
    public float gameSpeed = 1;
    public float timeToTick = 1;
    public Transform activeBlock;
    
    void Start(){
        
    }

    void Update(){
        timeToTick -= Time.deltaTime * gameSpeed;
        if (timeToTick <= 0f){
            activeBlock.GetComponent<BlockBehaviour>().Tick();
            timeToTick = 1;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            activeBlock.GetComponent<BlockBehaviour>().Strafe(Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            activeBlock.GetComponent<BlockBehaviour>().Strafe(Vector3.right);
        }
    

    
    }
}
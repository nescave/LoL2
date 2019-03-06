using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public bool canGoLeft = true;
    public bool canGoRight = true;

    private RaycastHit hit;

    void Start()
    {
        Tick();

        CheckObstacles();
    }

    void Update(){
        Debug.DrawLine(transform.position, transform.position + Vector3.right);
        Debug.DrawLine(transform.position, transform.position + Vector3.left);
        
    }

    public void Tick(){
        gameObject.transform.Translate(Vector3.down);
        CheckObstacles();
        
    }
    public void Strafe(Vector3 dir){
        bool canGoDir;
        if (dir.x == 1){
            canGoDir = canGoRight;
        }else{
            canGoDir = canGoLeft;
        }
        if(canGoDir){
            transform.Translate(dir);
            CheckObstacles();
        }
    }
    private void CheckObstacles(){
        if(Physics.Raycast(transform.position, Vector3.left, out hit,1f)){
            Debug.Log(hit.collider.transform.tag);
            if(hit.transform.tag == "obstacle"){
                canGoLeft = false;
            }else{
            canGoRight = true;
            }
        }
        if(Physics.Raycast(transform.position, Vector3.right, out hit,1f)){
            if(hit.transform.tag == "obstacle"){
                canGoRight = false;
            }else{
                canGoRight = true;
            }
        }
    }
}

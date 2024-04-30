using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float height;
    Vector2 pos;
    public Rigidbody2D rig2d;
    Vector2 spawn;
    public GameObject dialg;
    int jumpLeft=2;

    void OnCollisionEnter2D(Collision2D collision){
        jumpLeft=2;
        
    }

    void Awake() {
        rig2d=transform.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start() {
        speed=6;
        height=7;
        spawn=transform.position;
    }

    // Update is called once per frame
    void Update() {
        pos=transform.position;
        if(pos.y<=-20){
            TPSpawn();
        }else{
            if(!dialg.activeSelf&&jumpLeft>0){
                if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
                    rig2d.velocity=Vector2.up*height;
                    jumpLeft--;
                }
            }
            if(!dialg.activeSelf){
                pos.x+=speed*Input.GetAxis("Horizontal")*Time.deltaTime;
                transform.position=pos;
            }
        }

        
    }

    public void TPSpawn(float x=0){
        pos=transform.position;
        pos.y=spawn.y;
        pos.x=x;
        transform.position=pos;
    }

    public void smoke(){
        speed--;
        height=height-0.5f;
    }
}

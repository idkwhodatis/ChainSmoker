using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
    public GameObject dialg;
    public DialogueController dialgcl;
    public PlayerController player;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D coli){
        player.TPSpawn();
    }
}

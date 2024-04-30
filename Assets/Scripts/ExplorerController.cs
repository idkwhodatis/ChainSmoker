using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerController : MonoBehaviour {
    public DialogueController dialgcl;
    bool hasShown=false;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D coli){
        if(!hasShown){
            dialgcl.LoadSceneAfter("Scene2");
            dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep2"));
            hasShown=true;
        }
    }
}

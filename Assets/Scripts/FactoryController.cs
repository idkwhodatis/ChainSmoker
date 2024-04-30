using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController : MonoBehaviour {
    public DialogueController dialgcl;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D coli){
        dialgcl.LoadSceneAfter("Credits");
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep4q"));
    }
}

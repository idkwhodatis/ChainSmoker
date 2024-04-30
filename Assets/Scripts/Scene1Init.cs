using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Init : MonoBehaviour{
    public DialogueController dialgcl;
    public MenuController menu;
    void Awake(){
        dialgcl.DialogueContent(DialogueLoader.LoadDialogue("ep1"));
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}

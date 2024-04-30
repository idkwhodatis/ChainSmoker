using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Init : MonoBehaviour {
    public MenuController menu;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            menu.PauseResume();
        }
    }
}

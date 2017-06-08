using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    
    public void GameStart()
    {
    GameObject fade = (GameObject)Resources.Load("Prefabs/Fade");
    Instantiate(fade);

    //SceneManager.LoadScene("scene/main");
        
    }
}

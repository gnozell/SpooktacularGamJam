﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerLevel2 : MonoBehaviour {

    public bool WomanIsTriggered;
    public bool DeathIsTriggered;
    public string where;

    // Use this for initialization
    void Start () {
        WomanIsTriggered = false;
        DeathIsTriggered = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if(WomanIsTriggered)
        {
            SceneManager.LoadScene(where);
        }
        if (DeathIsTriggered)
        {
            SceneManager.LoadScene("GameOverMenu");
        }
	}
}
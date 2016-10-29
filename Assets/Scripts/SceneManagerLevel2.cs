using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerLevel2 : MonoBehaviour {

    public bool WomanIsTriggered;
    public bool DeathIsTriggered;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(WomanIsTriggered)
        {
            SceneManager.LoadScene("Level2Cont");
        }
        if (DeathIsTriggered)
        {
            SceneManager.LoadScene("GameOverMenu");
        }
	}
}

using UnityEngine;
using System.Collections;

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
            //win state
        }
        if (DeathIsTriggered)
        {
            //fail state
        }
	}
}

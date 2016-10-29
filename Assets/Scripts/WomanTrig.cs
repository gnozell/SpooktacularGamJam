using UnityEngine;
using System.Collections;

public class WomanTrig : MonoBehaviour {
    
    public GameObject sceneTrig;
    
    void OnTriggerEnter(Collider Other)
    {
        sceneTrig.GetComponent<SceneManagerLevel2>().WomanIsTriggered = true;
    }
}

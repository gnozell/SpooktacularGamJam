using UnityEngine;
using System.Collections;

public class DeathBoxTrig : MonoBehaviour {

    public GameObject sceneTrig;

    void OnTriggerEnter(Collider Other)
    {
        sceneTrig.GetComponent<SceneManagerLevel2>().DeathIsTriggered = true;
    }
}

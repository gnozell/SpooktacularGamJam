using UnityEngine;
using System.Collections;

public class CamerScript : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.y > 2f) {

			Vector3 newpos = player.transform.position;
			newpos.z = gameObject.transform.position.z;

			gameObject.transform.position = newpos;
		}
	
	}
}

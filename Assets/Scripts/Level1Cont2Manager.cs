using UnityEngine;
using System.Collections;

public class Level1Cont2Manager : MonoBehaviour {

	public GameObject daniel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		daniel.transform.position = new Vector3 (daniel.transform.position.x+5*Time.deltaTime,daniel.transform.position.y,daniel.transform.position.z);
		
	
	}
}

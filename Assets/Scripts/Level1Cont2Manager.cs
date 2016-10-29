using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level1Cont2Manager : MonoBehaviour {
	private float startTime;

	public GameObject daniel;

	// Use this for initialization
	void Start () {
		startTime = 8.5f;
	}
	
	// Update is called once per frame
	void Update () {
		daniel.transform.position = new Vector3 (daniel.transform.position.x+5*Time.deltaTime,daniel.transform.position.y,daniel.transform.position.z);
		if (startTime <= 0) {
			SceneManager.LoadScene ("Level 2");
		} else {
			startTime -= Time.deltaTime;
		}	
	}
}

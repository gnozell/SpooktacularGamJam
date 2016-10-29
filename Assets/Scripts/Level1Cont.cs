using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level1Cont : MonoBehaviour {
	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		if (startTime <= 0) {
			SceneManager.LoadScene ("Level1Cont2");
		} else {
			startTime -= Time.deltaTime;
		}
	}
}

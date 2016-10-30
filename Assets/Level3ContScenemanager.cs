using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3ContScenemanager : MonoBehaviour {


	float timer = 2.5f;
	public string scene= "Level3Cont2";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer < 0) {
			SceneManager.LoadScene (scene);
			
		} else {
			timer -= Time.deltaTime;
		}
	
	}
}

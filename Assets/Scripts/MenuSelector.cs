using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuSelector : MonoBehaviour {

	public void to_level1(){
		SceneManager.LoadScene ("Level 1");
	}

	public void to_settings(){
		SceneManager.LoadScene ("SettingsMenu");
	}

	public void to_gameselect(){
		SceneManager.LoadScene ("GameSelect");
	}

	public void to_mainmenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void to_exit(){
		Application.Quit ();
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3curtainslooking : MonoBehaviour {

	public bool looking = false;
	private Curtains_Controller c1;
	private float timer = .5f;
	private bool found = false;

	// Use this for initialization
	void Start () {
		c1 = transform.parent.GetComponent<Curtains_Controller> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (found) {
			if (timer < 0) {
				SceneManager.LoadScene ("GameOverMenu");
			}

			timer -= Time.deltaTime;
		}
	
	}

	void OnTriggerStay(Collider other){
		if (looking&&(other.tag == "Player")&&(!c1.shut)){
			// launched game over
			//
			Debug.Log("Daniel has been found!");
			found = true;


			
		}
	}


}

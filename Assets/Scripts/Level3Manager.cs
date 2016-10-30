using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3Manager : MonoBehaviour {

	public GameObject daniel;
	public Curtains_Controller c1;
	public Curtains_Controller c2;
	public Curtains_Controller c3;

	private float timer;
	private int phase;
	// Use this for initialization
	void Start () {
		timer = 2f;
	}

	// Update is called once per frame
	void Update () {
		if (daniel.transform.position.y < -5f) {
			SceneManager.LoadScene ("GameOverMenu");
		}

		switch (phase) {
		case 1:
			{
				if (timer < 0) {
					phase = 2;
					timer = 2f;
					if(c1 != null)
						c1.shut = true;
					if(c2 != null)
						c2.shut = true;
					if(c3 != null)
						c3.shut = true;
				} else {
					timer -= Time.deltaTime;
				}


				break;
			}
		case 2:{
				break;
			}

		default:
			{
				phase = 1;
				break;
			}
		}

	
	}
}

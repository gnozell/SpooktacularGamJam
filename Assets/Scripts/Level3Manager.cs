using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3Manager : MonoBehaviour {

	public GameObject daniel;
	public GameObject c1;
	public GameObject c2;
	public GameObject c3;

	public GameObject opener1;
	public GameObject opener2;
	public GameObject opener3;

	private Vector3 op1_st;
	private Vector3 op2_st;
	private Vector3 op3_st;

	private Vector3 door1_end;
	private Vector3 door2_end;
	private Vector3 door3_end;

	private float startTime = 0f;

	private float timer;
	private int phase;
	// Use this for initialization
	void Start () {
		timer = 2f;
		op1_st = opener1.transform.position;
		op2_st = opener2.transform.position;
		op3_st = opener3.transform.position;

		door1_end = c1.transform.position;
		door1_end.z = opener1.transform.position.z;

		door2_end = c2.transform.position;
		door2_end.z = opener2.transform.position.z;

		door3_end = c3.transform.position;
		door3_end.z = opener3.transform.position.z;

		startTime = Time.time;
	}

	private void next_phase(){
		phase += 1;
		timer = 1f;
		startTime = Time.time;

	}

	// Update is called once per frame
	void Update () {

		if (daniel.transform.position.y < -5f) {
			SceneManager.LoadScene ("GameOverMenu");
		}

		switch (phase) {
		case 0:
			{
				if (timer < 0) {
					
					c2.GetComponent<Curtains_Controller> ().shut = true;

					c1.GetComponent<Curtains_Controller> ().start_looking ();
					c2.GetComponent<Curtains_Controller> ().start_looking ();
					c3.GetComponent<Curtains_Controller> ().start_looking ();

					next_phase ();

				} else {
					timer -= Time.deltaTime;
				}
				break;
			}
		case 1:
			{
				// opener 1 opens curtain 1	
				float distCovered = (Time.time - startTime) * 1f;
				float fracJourney = distCovered / Vector3.Distance(op1_st, door1_end);
				opener1.transform.position = Vector3.Lerp (op1_st, door1_end, fracJourney);

				if (opener1.transform.position.x == door1_end.x) {
					c1.GetComponent<Curtains_Controller> ().shut = false;
					next_phase ();
				}


				break;
			}
		case 2:{
				// open curtains
				if (timer < 0) {
					next_phase ();

				} else {
					timer -= Time.deltaTime;
				}
				break;
			}

		case 3:
			{
				// return opener1 to spot
				c1.GetComponent<Curtains_Controller> ().shut = true;
				float distCovered = (Time.time - startTime) * 1f;
				float fracJourney = distCovered / Vector3.Distance(door1_end, op1_st);
				opener1.transform.position = Vector3.Lerp (door1_end, op1_st, fracJourney);
				if (opener1.transform.position.x == op1_st.x) {
					next_phase ();
				}
				break;
			}

		case 4:
			{
				// opener 1 opens curtain 1	
				float distCovered = (Time.time - startTime) * 1f;
				float fracJourney = distCovered / Vector3.Distance(op1_st, door3_end);
				opener1.transform.position = Vector3.Lerp (op1_st, door3_end, fracJourney);

				if (opener1.transform.position.x == door3_end.x) {
					c3.GetComponent<Curtains_Controller> ().shut = false;
					next_phase ();
				}


				break;
			}

		case 5:
			{
				// open curtains
				if (timer < 0) {
					next_phase ();

				} else {
					timer -= Time.deltaTime;
				}
				break;
			}

		case 6:
			{
				// return opener1 to spot
				c3.GetComponent<Curtains_Controller> ().shut = true;
				float distCovered = (Time.time - startTime) * 1f;
				float fracJourney = distCovered / Vector3.Distance(door3_end, op1_st);
				opener1.transform.position = Vector3.Lerp (door3_end, op1_st, fracJourney);
				if (opener1.transform.position.x == op1_st.x) {
					next_phase ();
				}
				break;
			}

		case 7:
			{
				break;
			}
		
		default:
			{
				phase = 0;
				break;
			}
		}

	
	}
}

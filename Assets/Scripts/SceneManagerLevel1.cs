using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerLevel1 : MonoBehaviour {

	public GameObject hill1;
	public GameObject hill2;
	public GameObject castlehill;

	public Transform hill1end;
	public Transform hill2end;
	public Transform castleend;

	private float startTime;
	private int phase = 1;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (phase) {
		case 1:{
				float Hill1Y = hill1.GetComponent<Bobbing> ().originalY;
				if (Hill1Y < hill1end.position.y) {
					hill1.GetComponent<Bobbing> ().originalY = Hill1Y + (20 * Time.deltaTime);
				} else {
					phase = 2;
				}
				break;

			}

		case 2:{
				float Hill2Y = hill2.GetComponent<Bobbing> ().originalY;
				if (Hill2Y < hill2end.position.y) {
					hill2.GetComponent<Bobbing> ().originalY = Hill2Y + (20 * Time.deltaTime);
				} else {
					phase = 3;
				}
				break;

			}
		case 3:{
				float Hill3Y = castlehill.GetComponent<Bobbing> ().originalY;
				if (Hill3Y < castleend.position.y) {
					castlehill.GetComponent<Bobbing> ().originalY = Hill3Y + (23 * Time.deltaTime);
				} else {
					phase = 3;
					startTime = 3f;
				}
				break;

			}

		case 4:{

				if (startTime > 0) {
					SceneManager.LoadScene ("Level1Cont");
				} else {
					startTime -= Time.deltaTime;
				}
				//wait then next scene
				break;

			}

		default:{
				phase = 1;
				break;
			}
		}
	
	}
}

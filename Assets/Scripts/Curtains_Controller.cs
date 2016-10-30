using UnityEngine;
using System.Collections;

public class Curtains_Controller : MonoBehaviour {

	public SpriteRenderer c1;
	public SpriteRenderer c2;

	public Sprite closed;
	public Sprite open;

	public Level3curtainslooking looking;

	public bool shut = true;

	public void start_looking(){
		looking.looking = true;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (shut) {
			if ((c1.sprite != closed)&&(c2.sprite != closed)) {
				c1.sprite = closed;
				c2.sprite = closed;
			}
			
		} else {
			if ((c1.sprite != open)&&(c2.sprite != open)) {
				c1.sprite = open;
				c2.sprite = open;
			}
		}
		
	
	}
}

using UnityEngine;
using System.Collections;

public class FadeinTime : MonoBehaviour {

	public float timer = 2f;
	private SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer < 0) {
			Color col = sprite.color;
			col.a -= 0.01f;
			sprite.color = col;
			
			
		} else {
			timer -= Time.deltaTime;
		}
	
	}
}

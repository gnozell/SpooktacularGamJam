using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadingText : MonoBehaviour {

	// public variables
	public Text text; // the text that the script will manipulate
	public int textsBefore; // how many other texts we are going to be fading before this one

	// private variables
	private bool fadeOut; // flag to know when we are fading out
	private Color color; // use this to modify the text color
	private float waitTimer; // waiting once we are fully faded in
	private float outerWaitTimer; // waiting for previous text to fade out

	// Use this for initialization
	void Start () {
		fadeOut = false;
		color = text.color;
		color.a = 0;
		text.color = color;
		waitTimer = 0;
		outerWaitTimer = 0;
	}

	// Update is called once per frame
	void Update () {
		outerWaitTimer += Time.deltaTime;
		if (outerWaitTimer >= (8 * textsBefore)) {
			if (!fadeOut) {
				// fading the color in
				color.a += 0.006f;
				text.color = color;

				if (color.a >= 1.0f) {
					// so we don't fade in then immediately start fading out
					waitTimer += Time.deltaTime;
					if (waitTimer >= 1.7f)
						fadeOut = true;
				}			
			} else {
				// fading the color out
				color.a -= 0.008f;
				text.color = color;
			}
		}
	}
}

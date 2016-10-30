using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadingSceneOut : MonoBehaviour {
	public SpriteRenderer fadeOutTexture;
	public float numOfTexts = 0;
	public float fadeSpeed = 0.002f;

	private Color color;
	private float waitTimer = 0f;

	void Start() {
		color = fadeOutTexture.color;
		color.a = 0f;
		fadeOutTexture.color = color;
	}

	void Update() {
		waitTimer += Time.deltaTime;
		Debug.Log ("Hello? Yes? Boosted?");
		if (waitTimer >= (5 * numOfTexts)) {
			color.a += fadeSpeed;
			Debug.Log (color.a);
			fadeOutTexture.color = color;
			Debug.Log (fadeOutTexture.color.a);
		}
	}
}


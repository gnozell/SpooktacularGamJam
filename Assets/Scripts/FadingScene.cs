using UnityEngine;
using System.Collections;

public class FadingScene : MonoBehaviour {
	public SpriteRenderer fadeOutTexture;
	public float fadeSpeed = 0.008f;
	public float numOfTexts = 0;

	private Color color;
	private float waitTimer = 0;

	void Start() {
		color = fadeOutTexture.color;
		color.a = 0f;
		fadeOutTexture.color = color;
	}

	void Update() {
		waitTimer += Time.deltaTime;
		if (waitTimer >= (20 * numOfTexts)) {
			color.a += 0.001f;
			fadeOutTexture.color = color;
		}
	}
}


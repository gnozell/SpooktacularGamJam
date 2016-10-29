using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadingSceneIn : MonoBehaviour {
	public SpriteRenderer fadeInTexture;
	public float numOfTexts = 0;
	public float fadeSpeed = 0.003f;

	private Color color;

	// Use this for initialization
	void Start () {
		color = fadeInTexture.color;
		color.a = 1f;
		fadeInTexture.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		color.a -= fadeSpeed;
		fadeInTexture.color = color;
	}
}

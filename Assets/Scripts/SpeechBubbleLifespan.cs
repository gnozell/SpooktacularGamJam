using UnityEngine;
using System.Collections;

public class SpeechBubbleLifespan : MonoBehaviour {
    public float lifespan = 10;
    float i;
    SpriteRenderer spr;
	// Use this for initialization
	void Start () {
        spr = this.GetComponent<SpriteRenderer>();
        i = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        i += Time.deltaTime;
        if (i > lifespan) spr.color = new Color(spr.color.r, spr.color.b, spr.color.g, spr.color.a-.008f);
        if (i > lifespan+20) Destroy(this.gameObject);
	}
}

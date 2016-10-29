using UnityEngine;
using System.Collections;

public class dan_anim : MonoBehaviour {

    public GameObject Rarm;
    public GameObject Rthigh;
    public GameObject Rfoot;
    public GameObject Larm;
    public GameObject Lthigh;
    public GameObject Lfoot;
    public Sprite faceRight;
    public Sprite faceLeft;
    public Sprite faceFront;
    SpriteRenderer spriter;

    float[] timers = new float[6];
    int[] isGoingLeft = new int [] {1, -1, 1, -1, -1, 1};
    public float speed;

    // Use this for initialization
    void Start () {
        spriter = this.GetComponent<SpriteRenderer>();
        //limbSpinLeft = 1;
    }
	
	// Update is called once per frame
	void Update () {
        Larm.transform.Rotate(0, 0, isGoingLeft[0]);
        Lthigh.transform.Rotate(0, 0, isGoingLeft[1]);
        Lfoot.transform.Rotate(0, 0, isGoingLeft[2]);
        Rarm.transform.Rotate(0, 0, isGoingLeft[3]);
        Rthigh.transform.Rotate(0, 0, isGoingLeft[4]);
        Rfoot.transform.Rotate(0, 0, isGoingLeft[5]);

        if (speed < 0) {
            spriter.sprite = faceLeft;
        } else if (speed > 0) {
            spriter.sprite = faceRight;
        }

        if (speed == 0) spriter.sprite = faceFront;

        if (timers[0] > 15) isGoingLeft[0] = -1;
        if (timers[0] < -45) isGoingLeft[0] = 1;

        if (timers[1] > 20) isGoingLeft[1] = -1;
        if (timers[1] < -15) isGoingLeft[1] = 1;

        if (timers[2] > 20) isGoingLeft[2] = -1;
        if (timers[2] < -20) isGoingLeft[2] = 1;

        if (timers[3] > 45) isGoingLeft[3] = -1;
        if (timers[3] < -15) isGoingLeft[3] = 1;

        if (timers[4] > 15) isGoingLeft[4] = -1;
        if (timers[4] < -20) isGoingLeft[4] = 1;

        if (timers[5] > 20) isGoingLeft[5] = -1;
        if (timers[5] < -20) isGoingLeft[5] = 1;

        timers[0] += (float)isGoingLeft[0] * speed / 30f;
        timers[1] += (float)isGoingLeft[1] * speed / 30f;
        timers[2] += (float)isGoingLeft[2] * speed / 30f;
        timers[3] += (float)isGoingLeft[3] * speed / 30f;
        timers[4] += (float)isGoingLeft[4] * speed / 30f;
        timers[5] += (float)isGoingLeft[5] * speed / 30f;
    }
}

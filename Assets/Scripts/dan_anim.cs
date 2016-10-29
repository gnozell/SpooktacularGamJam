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

    int[] timers = new int[6];
    int[] isGoingLeft = new int [] {1, -1, 1, -1, -1, 1};
    public int speed;

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

        timers[0] += isGoingLeft[0];
        timers[1] += isGoingLeft[1];
        timers[2] += isGoingLeft[2];
        timers[3] += isGoingLeft[3];
        timers[4] += isGoingLeft[4];
        timers[5] += isGoingLeft[5];
    }
}

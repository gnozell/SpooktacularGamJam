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
    Rigidbody rb;

    public float maxX;
    public float maxZ;
    public float minX;
    public float minZ;

    float[] isGoingLeft = new float [] {1f, -1f, 1f, -1f, -1f, 1f};
    public float speed;

    // Use this for initialization
    void Start () {
        spriter = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody>();
        //limbSpinLeft = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        speed = 1;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        if(Input.GetAxis("Jump") != 0 && this.rb.velocity.y == 0) rb.AddForce(new Vector3(0, 150f, 0));

        transform.Translate(x, 0, z);

        //if (this.transform.position.x > minX || this.transform.position.x < maxX) transform.Translate(x * -1, 0, 0);
        //if (this.transform.position.z > minZ || this.transform.position.z < maxZ) transform.Translate(0, 0, z * -1);
        spriter.sprite = faceFront;
        if (Input.GetAxis("Horizontal") < 0f)
        {
            spriter.sprite = faceLeft;
        }
        else if (Input.GetAxis("Horizontal") > 0f)
        {
            spriter.sprite = faceRight;
        }

        if (Larm.transform.rotation.z*360 >= 15) isGoingLeft[0] = -1f;
        if (Larm.transform.rotation.z * 360 <= -45) isGoingLeft[0] = 1f;

        if (Lthigh.transform.rotation.z * 360 >= 20) isGoingLeft[1] = -1f;
        if (Lthigh.transform.rotation.z * 360 <= -20) isGoingLeft[1] = 1f;

        if (Lfoot.transform.rotation.z * 360 >= 15) isGoingLeft[2] = -1f;
        if (Lfoot.transform.rotation.z * 360 <= -45) isGoingLeft[2] = 1f;

        if (Rarm.transform.rotation.z * 360 >= 45) isGoingLeft[3] = -1f;
        if (Rarm.transform.rotation.z * 360 <= -15) isGoingLeft[3] = 1f;

        if (Rthigh.transform.rotation.z * 360 >= 20) isGoingLeft[4] = -1f;
        if (Rthigh.transform.rotation.z * 360 <= -20) isGoingLeft[4] = 1f;

        if (Rfoot.transform.rotation.z * 360 >= 15) isGoingLeft[5] = -1f;
        if (Rfoot.transform.rotation.z * 360 <= -45) isGoingLeft[5] = 1f;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Larm.transform.Rotate(0, 0, isGoingLeft[0]);
            Lthigh.transform.Rotate(0, 0, isGoingLeft[1]);
            Lfoot.transform.Rotate(0, 0, isGoingLeft[2]);
            Rarm.transform.Rotate(0, 0, isGoingLeft[3]);
            Rthigh.transform.Rotate(0, 0, isGoingLeft[4]);
            Rfoot.transform.Rotate(0, 0, isGoingLeft[5]);

            /*
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

            timers[1] += (float)isGoingLeft[1] * speed * Time.deltaTime;
            timers[2] += (float)isGoingLeft[2] * speed * Time.deltaTime;
            timers[3] += (float)isGoingLeft[3] * speed * Time.deltaTime;
            timers[4] += (float)isGoingLeft[4] * speed * Time.deltaTime;
            timers[5] += (float)isGoingLeft[5] * speed * Time.deltaTime;*/
        }
    }
}

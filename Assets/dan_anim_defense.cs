using UnityEngine;
using System.Collections;

public class dan_anim_defense : MonoBehaviour
{

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
    
    public float startTime = 0;
    float i = 0;
    public bool controllable = true;
    float[] isGoingLeft = new float[] { 1f, -1f, 1f, -1f, -1f, 1f , 1f};
    public float speed;

    // Use this for initialization
    void Start()
    {
        spriter = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody>();
        //limbSpinLeft = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime != 0 && i < startTime)
        {
            rb.isKinematic = true;
            i += Time.deltaTime;
            return;
        }
        speed = 1;
        if (controllable == true)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
            if (Input.GetButtonDown("Jump") && this.rb.velocity.y < .01 && this.rb.velocity.y > -.01) rb.AddForce(new Vector3(0, 600f, 0));
            else if (Input.GetAxis("Jump") == 0 && this.rb.velocity.y > .1f) rb.AddForce(new Vector3(0, -250f, 0));

            transform.Translate(x, 0, z);

            spriter.sprite = faceFront;
            if (Input.GetAxis("Horizontal") > 0f)
            {
                spriter.sprite = faceLeft;
            }
            else if (Input.GetAxis("Horizontal") < 0f)
            {
                spriter.sprite = faceRight;
            }
        }
        else
        {
            transform.Translate(.1f, 0, 0);
            rb.isKinematic = true;
        }
        if (Larm.transform.rotation.z * 360 >= 15) isGoingLeft[0] = -1f;
        if (Larm.transform.rotation.z * 360 <= -45) isGoingLeft[0] = 1f;

        if (Lthigh.transform.rotation.z * 360 >= 20) isGoingLeft[1] = -1f;
        if (Lthigh.transform.rotation.z * 360 <= -20) isGoingLeft[1] = 1f;

        if (Lfoot.transform.rotation.z * 360 >= 15) isGoingLeft[2] = -1f;
        if (Lfoot.transform.rotation.z * 360 <= -45) isGoingLeft[2] = 1f;

        if (Rarm.transform.rotation.z * 360 >= 45) isGoingLeft[3] = -1f;
        if (Rarm.transform.rotation.z * 360 <= -60) isGoingLeft[3] = 1f;

        if (Rthigh.transform.rotation.z * 360 >= 20) isGoingLeft[4] = -1f;
        if (Rthigh.transform.rotation.z * 360 <= -20) isGoingLeft[4] = 1f;

        if (Rfoot.transform.rotation.z * 360 >= 15) isGoingLeft[5] = -1f;
        if (Rfoot.transform.rotation.z * 360 <= -45) isGoingLeft[5] = 1f;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 || controllable == false)
        {
            Larm.transform.Rotate(0, 0, isGoingLeft[0]);
            Lthigh.transform.Rotate(0, 0, isGoingLeft[1]);
            Lfoot.transform.Rotate(0, 0, isGoingLeft[2]);
            Rarm.transform.Rotate(0, 0, isGoingLeft[3]);
            Rthigh.transform.Rotate(0, 0, isGoingLeft[4]);
            Rfoot.transform.Rotate(0, 0, isGoingLeft[5]);
        }
    }
}

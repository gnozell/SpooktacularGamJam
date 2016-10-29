using UnityEngine;
using System.Collections;

public class dan_anim : MonoBehaviour {

    public GameObject Rarm;
    public GameObject Rthigh;
    public GameObject Rfoot;
    public GameObject Larm;
    public GameObject Lthigh;
    public GameObject Lfoot;
    public int speed;
    bool limbSpinLeft;

    // Use this for initialization
    void Start () {
        limbSpinLeft = true;
    }
	
	// Update is called once per frame
	void Update () {
        Rarm.transform.rotation = new Quaternion(Rarm.transform.rotation.w, Rarm.transform.rotation.x, Rarm.transform.rotation.y, Rarm.transform.rotation.z);
	}
}

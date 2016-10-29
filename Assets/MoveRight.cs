using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveRight : MonoBehaviour {

    public bool moveLeft = false;
    float i;
    public float startTime;
    public float endTime = 100;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        i += Time.deltaTime;
        if (i >= startTime)
        {
            if (moveLeft == false) transform.Translate(-.1f, 0, 0);
            else transform.Translate(.1f, 0, 0);
        }
        if(i >= endTime)
            SceneManager.LoadScene("Level 3");
    }
}

using UnityEngine;
using System.Collections;

public class DestructibleCitizen : MonoBehaviour
{
    bool isDead;
    public GameObject sceneTrig;

    void Start()
    {
        isDead = false;
    }

    void Update()
    {
        if (isDead)
        {
            transform.Translate(0, -.01f, -.5f);
            transform.Rotate(0, 0, 10f);
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        isDead = true;
        this.GetComponent<Bobbing>().enabled = false;
    }
}

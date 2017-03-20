using UnityEngine;
using System.Collections;

public class Addforce : MonoBehaviour
{

    public float forceMultiplier = -10;
    public int scoreValue = 200;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().velocity = col.gameObject.GetComponent<Rigidbody>().velocity * forceMultiplier;
            Debug.Log("osui");
        }
    }
}

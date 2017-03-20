using UnityEngine;
using System.Collections;

public class TpIn : MonoBehaviour {

    public GameObject player;
    Vector3 tpSpawn;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        tpSpawn = GameObject.FindGameObjectWithTag("TpSpawn").transform.position;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.gameObject.transform.position = tpSpawn;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.gameObject.transform.position = tpSpawn;
        }
    }*/

}

using UnityEngine;
using System.Collections;

public class FloorIsLava : MonoBehaviour {

    public GameObject player;
    Vector3 spawn;

    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawn").transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.gameObject.transform.position = spawn;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;

            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            StartGame.gameIsActive = false;

            Debug.Log("hello from floor");
        }
    }
}

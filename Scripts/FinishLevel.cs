using UnityEngine;
using System.Collections;

public class FinishLevel : MonoBehaviour {

    bool isPlayed;

	// Use this for initialization
	void Start () {
        isPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            LevelSuccess();
        }
    }

    void LevelSuccess()
    {
        isPlayed = true;
    }
}

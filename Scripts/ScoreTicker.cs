using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTicker : MonoBehaviour {

    public static float levelScore = 1000;

    public Text scoreText;

	// Use this for initialization
	void Start () {
        StartCoroutine("decreaseScore");
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = levelScore.ToString();

        if(levelScore <= 0)
        {
            StopCoroutine("decreaseScore");
        }
	}

    IEnumerator decreaseScore()
    {
        yield return new WaitForSeconds(0.1f);
        levelScore -= 1;
        StartCoroutine("decreaseScore");
    }
}

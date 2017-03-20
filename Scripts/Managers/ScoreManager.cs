using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static float currentScore;
    public static float totalScore;

    public Text scoreText;

    // Use this for initialization
    void Start () {

        scoreText.text = ScoreTicker.levelScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(totalScore);
    }


}

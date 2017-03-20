using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScoreLoader : MonoBehaviour {

    public Text endScoreText;

    // Use this for initialization
    void Start () {
        endScoreText.text = ScoreManager.totalScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

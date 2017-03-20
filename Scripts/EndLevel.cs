using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    public GameObject player;
    public static bool lv1IsPlayed;
    public static bool lv2IsPlayed;
    public static bool lv3IsPlayed;
    public static bool lv4IsPlayed;

    void Start()
    {
        lv1IsPlayed = false;
        lv2IsPlayed = false;
        lv3IsPlayed = false;
        lv4IsPlayed = false;
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

    }


    void OnTriggerEnter(Collider other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (other.tag == "Player")
        {
            //goto level passed scene (additive)
            //SceneManager.LoadSceneAsync("LevelComplete", LoadSceneMode.Single);

            StartGame.gameIsActive = false;

            if(sceneName == "Level1")
            {
                lv1IsPlayed = true;
            }
            if (sceneName == "Level2")
            {
                lv2IsPlayed = true;
            }
            if (sceneName == "Level3")
            {
                lv3IsPlayed = true;
            }
            if (sceneName == "Level4")
            {
                lv4IsPlayed = true;
            }

            if(sceneName == "Level1" || sceneName == "Level2" || sceneName == "Level3")
            {
                SceneManager.LoadSceneAsync("LevelComplete", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadSceneAsync("EndScene", LoadSceneMode.Single);
            }

            //ScoreTicker.levelScore = ScoreManager.currentScore;
            ScoreManager.totalScore += ScoreTicker.levelScore;

        }
    }


}

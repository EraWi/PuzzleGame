using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour {

    public Button nextButton;

    void Start()
    {
        Button btn = nextButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if(EndLevel.lv1IsPlayed == true)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        if (EndLevel.lv2IsPlayed == true)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        if (EndLevel.lv3IsPlayed == true)
        {
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
    }
}

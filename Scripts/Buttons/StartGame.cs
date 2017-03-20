using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

    public Button startButton;
    public GameObject player;
    public static bool gameIsActive = false;

    void Start () {
        Button btn = startButton.GetComponent<Button>();
        GameObject pl = player.GetComponent<GameObject>();
        btn.onClick.AddListener(TaskOnClick);        
    }
	
    void TaskOnClick()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;

        gameIsActive = true;
    }
}

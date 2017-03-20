using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetGame : MonoBehaviour {

    public Button resetButton;
    public GameObject player;
    Vector3 spawn;

    void Start()
    {
        Button btn = resetButton.GetComponent<Button>();
        GameObject pl = player.GetComponent<GameObject>();
        btn.onClick.AddListener(TaskOnClick);

        spawn = GameObject.FindGameObjectWithTag("Spawn").transform.position;
    }

    void TaskOnClick()
    {
        player.gameObject.transform.position = spawn;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;

        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        StartGame.gameIsActive = false;
    }
}

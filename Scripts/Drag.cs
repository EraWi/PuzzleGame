using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]

public class Drag : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;
    bool objectSelected = false;


    void Update()
    {
        if (Input.GetKey(KeyCode.E) && objectSelected == true && StartGame.gameIsActive == false)
        {
            Debug.Log("hello from E");
            transform.Rotate(Vector3.right * 80 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.Q) && objectSelected == true && StartGame.gameIsActive == false)
        {
            Debug.Log("hello from Q");
            transform.Rotate(Vector3.left * 80 * Time.deltaTime);

        }
        else
        {
            objectSelected = false;
        }
    }

    void OnMouseDown()
    {
        if (StartGame.gameIsActive == false)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

    }

    void OnMouseDrag()
    {

        if (StartGame.gameIsActive == false)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;

            objectSelected = true;
        }
    }
}
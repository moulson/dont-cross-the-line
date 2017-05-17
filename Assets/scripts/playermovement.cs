using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //set to portrait
        Screen.orientation = ScreenOrientation.Portrait;
	}
    public int LeftBoundary, RightBoundary, moveSpeed;
    int screenHeight = Screen.height;
    int screenWidth = Screen.width;
	void Update ()
    {
        //Player constantly moving forwards
        MoveForwards();
        CheckLeft();
        CheckRight();

    }

    private void CheckRight()
    {
        if (Input.GetTouch(0).position.x > screenWidth / 2 && gameObject.transform.position.z >= RightBoundary)
        {
            gameObject.transform.Translate(Vector3.left * (Time.deltaTime * (moveSpeed / 10)));
        }
    }

    private void CheckLeft()
    {
        if (Input.GetTouch(0).position.x < screenWidth / 2 && gameObject.transform.position.z <= LeftBoundary)
        {
            gameObject.transform.Translate(Vector3.right * (Time.deltaTime * (moveSpeed / 10)));
        }
    }

    private void MoveForwards()
    {
        gameObject.transform.Translate(Vector3.back * (Time.deltaTime * (moveSpeed / 10)));
    }
}

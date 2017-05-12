using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyemovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//will add initialization stuff later
	}
	
	// Update is called once per frame
	void Update () {
        //Keyboard controls TODO: Support mobile
        float transX = Input.GetAxis("Horizontal");
        float transY = Input.GetAxis("Vertical");
        float fastTransX = 2 * Input.GetAxis("Horizontal");
        float fastTransY = 2 * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(fastTransX + fastTransY, 0, fastTransY - fastTransX);
        }
        else
        {
            transform.Translate(transX + transY, 0, transY - transX);
        }

        //Mouse scrolling

        float mousePosX = Input.mousePosition.x;
        float mousePosY = Input.mousePosition.y;
        int scrollDistance = 5;
        //float scrollSpeed = 70;

        //Horizontal camera movement
        if (mousePosX < scrollDistance)
            transform.Translate(-1, 0, 1);
        if (mousePosX >= Screen.width - scrollDistance)
            transform.Translate(1, 0, -1);

        if (mousePosY < scrollDistance)
            transform.Translate(-1, 0, -1);
        if (mousePosY >= Screen.height - scrollDistance)
            transform.Translate(1, 0, 1);

        GameObject Eye = GameObject.Find("Eye");
        if(Input.GetAxis("Mouse ScrollWheel") > 0 && Eye.GetComponent<Camera>().orthographicSize > 4)
        {
            Eye.GetComponent<Camera>().orthographicSize = Eye.GetComponent<Camera>().orthographicSize - 4;
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0 && Eye.GetComponent<Camera>().orthographicSize < 80)
        {
            Eye.GetComponent<Camera>().orthographicSize = Eye.GetComponent<Camera>().orthographicSize + 4;
        }

        //Default zoom
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            Eye.GetComponent<Camera>().orthographicSize = 50;
        }
    }
}

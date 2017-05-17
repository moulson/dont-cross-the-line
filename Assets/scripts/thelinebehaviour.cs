using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thelinebehaviour : MonoBehaviour {
    public GameObject GameOverScreen;
    public float lineSpeed;
	// Use this for initialization
	void Start () {
        GameOverScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //Move 
        transform.Translate(lineSpeed * Time.deltaTime,0,0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
    public void RestartGame()
    {
        GameOverScreen.SetActive(false);
        gameObject.transform.SetPositionAndRotation(new Vector3(-127, 18, 60), gameObject.transform.rotation);
        var player = GameObject.Find("the_player");
        player.transform.SetPositionAndRotation(new Vector3(-50, 4, 50), player.transform.rotation);
    }
}

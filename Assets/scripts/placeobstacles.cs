using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class placeobstacles : MonoBehaviour {
    private GameObject startPoint;
    private Vector3 lastLocation;
    public List<Object> Obstacles;
	// Use this for initialization
	void Start () {
        Obstacles = Resources.LoadAll("obstacles/").ToList();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

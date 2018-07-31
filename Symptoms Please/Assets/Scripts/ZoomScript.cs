using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Camera>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(ZoomControl.zoomActive == "y")
        {
            GetComponent<Camera>().enabled = true; 
        } else
        {
            GetComponent<Camera>().enabled = false; 
        }

	}
}

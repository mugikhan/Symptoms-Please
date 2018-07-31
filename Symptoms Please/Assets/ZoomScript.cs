using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {


    public Camera[] zoomCam;
	// Use this for initialization
	void Start () {
        for(int i =0; i< zoomCam.Length; i++)
        {
           zoomCam[i].GetComponent<Camera>().enabled = false;
        }
       
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Zoom Active: " + ZoomControl.zoomActive);
		if(ZoomControl.zoomActive != "0")
        {
            int index; 
            int.TryParse(ZoomControl.zoomActive, out index);
            //Debug.Log("Index: " + (index - 1));
            zoomCam[index-1].GetComponent<Camera>().enabled = true;
            
        } else
        {
            for (int i = 0; i < zoomCam.Length; i++)
            {
                zoomCam[i].GetComponent<Camera>().enabled = false;
            }
        }

	}
}

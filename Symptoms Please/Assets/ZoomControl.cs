using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour {

    public static string zoomActive = "n";

    private void OnMouseDown()
    {
        if(zoomActive == "n"){
            zoomActive = "y";
        } else 
        {
            zoomActive = "n";
        }
    }
}

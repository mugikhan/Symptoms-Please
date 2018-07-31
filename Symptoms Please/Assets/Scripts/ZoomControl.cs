using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour {

    public static string zoomActive = "0";
    public static string diseaseType = "";

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                diseaseType = hit.collider.gameObject.tag;

                //Debug.Log(diseaseType);
                if (zoomActive == "0")
                {
                    zoomActive = diseaseType;
                }
                else
                {
                    zoomActive = "0";
                }
            }
        }
    }
}

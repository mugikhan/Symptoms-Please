using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class Cues : MonoBehaviour {
    public Transform scrollView;

    private Vector3 position = new  Vector3(0, 0, 0);
    private float rectPos = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Q1_Done()
    {
        Debug.Log("DONE LINK1");
        Transform content = scrollView.transform.Find("Content");
        //This relates to the rect transform and sets its position correctly
        /*RectTransform rt = content.transform.GetComponent<RectTransform>();
        float left = rt.offsetMin.x;
        float right = -rt.offsetMax.x;
        float top = -rt.offsetMax.y;
        float bottom = rt.offsetMin.y;
        rt.offsetMin = new Vector2(0 , 0);
        rt.offsetMax = new Vector2(0, 0);*/
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }

    void Q3_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }

    [StoryCue("Has he been tested for HIV?", "Done")]
    void passage4_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Wait, neither you nor he has been tested for HIV?", "Done")]
    void passage5_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("HIV isn't contracted through homosexual sex only, and it can only be passed on by someone who has HIV. You may be lucky and not have HIV.", "Done")]
    void passage6_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Prescribe ARVs", "Done")]
    void passage7_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Recommend an HIV test", "Done")]
    void passage8_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("You can live with HIV, many people have lived full lives with HIV, just be sure to take your ARVs correctly", "Done")]
    void passage9_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Goodbye", "Done")]
    void passage10_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("You can't know that for certain", "Done")]
    void passage11_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Next patient", "Done")]
    void passage12_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Why did you sleep with another man? Are you homosexual?", "Done")]
    void passage13_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Why will you die?", "Done")]
    void passage14_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Loving another man is not sinful", "Done")]
    void passage15_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("You deserve to get HIV for having sex with another man", "Done")]
    void passage16_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Q2", "Done")]
    void passage17_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Does this man have HIV?", "Done")]
    void passage18_Done()
    {
        Transform content = scrollView.transform.Find("Content");
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }



}

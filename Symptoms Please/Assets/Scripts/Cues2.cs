using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class Cues2 : MonoBehaviour {
    public Transform scrollView;
    public Transform content;

    private Vector3 position = new  Vector3(0, 0, 0);
    private float rectPos = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetScrollView()
    {
        scrollView = GameObject.FindGameObjectWithTag("Scrollview").transform;
        content = scrollView.transform.Find("Content");
    }

    [StoryCue("Illness", "Done")]
    void passage1_Done()
    {
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
    [StoryCue("Fever", "Done")]
    void passage2_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }

    [StoryCue("Nausea", "Done")]
    void passage3_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Appetite", "Done")]
    void passage4_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Phlegm", "Done")]
    void passage5_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Headaches", "Done")]
    void passage6_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Short of breath", "Done")]
    void passage7_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Intro", "Done")]
    void passage8_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Family History", "Done")]
    void passage9_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Weight loss story", "Done")]
    void passage10_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Fatigue story", "Done")]
    void passage11_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Hunger story", "Done")]
    void passage12_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Irritability story", "Done")]
    void passage13_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
    }
    [StoryCue("Diagnose", "Done")]
    void passage14_Done()
    {
        content.transform.position = position;
        content.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        content.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        Destroy(transform.parent.gameObject);
    }
    
}

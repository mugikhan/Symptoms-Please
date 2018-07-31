using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Button btnSpawn;

    public int x = 1;

    public Transform patient;

    private Cues cueScript;
    // Use this for initialization
    void Start () {
        cueScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<Cues>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnSpawnBtnClick()
    {
        Instantiate(patient, new Vector3(0, 0, -1f), Quaternion.identity);
        cueScript.GetScrollView();
    }
}

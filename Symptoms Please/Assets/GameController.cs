using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public List<string> symptomsList = new List<string>();

    protected FileInfo sourceFile = null;
    protected StreamReader textReader = null;
    protected string text = " ";

    public Button btnSpawn;

    public int x = 1;

    public Transform patient;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnSpawnBtnClick()
    {
        Instantiate(patient, new Vector3(0, 0, 0), Quaternion.identity);

    }
}

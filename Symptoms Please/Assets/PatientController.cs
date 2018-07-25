using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PatientController : MonoBehaviour {
    public List<string> patientSymptoms = new List<string>();

    private GameController gameControllerScript;

    protected FileInfo sourceFile = null;
    protected StreamReader textReader = null;
    protected string text = " ";

    int x = 0;
    int y = 3;

    // Use this for initialization
    void Start () {
        GameObject gameControllerObj = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObj != null)
        {
            gameControllerScript = gameControllerObj.GetComponent<GameController>();
        }
        if (gameControllerObj == null)
        {
            Debug.Log("Cannot find 'gameController' script");
        }

        int randNum = Random.Range(x, y);

        if(gameControllerScript.x == 1)
        {
            sourceFile = new FileInfo("Symptoms.txt");
            gameControllerScript.x++;
        }
        else if(gameControllerScript.x == 2)
        {
            sourceFile = new FileInfo("TB.txt");
            gameControllerScript.x++;
        }
        else if(gameControllerScript.x == 3)
        {
            sourceFile = new FileInfo("HepC.txt");
        }
        textReader = sourceFile.OpenText();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (text != null)
        {
            text = textReader.ReadLine();
            if (text != null)
            {
                patientSymptoms.Add(text);
            }
        }


    }
}

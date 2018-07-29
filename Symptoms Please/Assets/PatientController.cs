using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Cradle;
using UnityEngine.UI;

public class PatientController : MonoBehaviour {
    public List<string> patientSymptoms = new List<string>();

    public Story HIVStory;

    private GameController gameControllerScript;

    protected FileInfo sourceFile = null;
    protected StreamReader textReader = null;
    protected string text = " ";

    int x = 0;
    int y = 3;

    public Text passageText;
    public Text linkText;

    // Use this for initialization
    void Start () {
        HIVStory = GameObject.FindGameObjectWithTag("Player").GetComponent<HIVArc>();
        passageText = GameObject.FindGameObjectWithTag("Passage").GetComponent<Text>();
        linkText = GameObject.FindGameObjectWithTag("Link").GetComponent<Text>();
        GameObject gameControllerObj = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObj != null)
        {
            gameControllerScript = gameControllerObj.GetComponent<GameController>();
        }
        if (gameControllerObj == null)
        {
            Debug.Log("Cannot find 'gameController' script");
        }

        //HIVStory.OnOutput += HIVStory_OnOutput;
        //HIVStory.Begin();

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

        print(HIVStory.GetCurrentText());
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
        //passageText = (StoryText)HIVStory.GetCurrentText();
        //linkText = (StoryLink)HIVStory.GetCurrentLinks();

    }

    void HIVStory_OnOutput(StoryOutput output)
    {
        // Do something with the output here
        //Debug.Log(output.Text);
        //var text = (StoryText)output;
        //print(HIVStory.GetCurrentText());
    }

}

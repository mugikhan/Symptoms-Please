using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Button btnSpawn;

    public int x = 1;

    public Transform Liam;
    public Transform Shane;
    public Transform Rodwin;

    private Cues cueCodeineScript;
    private Cues1 cueDiabetesScript;
    private Cues2 cueHealthyScript;

	public AudioClip doorOpen;
	public AudioClip chairSlide;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

    }

	IEnumerator chair(){
		yield return new WaitForSeconds (this.GetComponent<AudioSource> ().clip.length);
		this.GetComponent<AudioSource> ().clip = chairSlide;
		this.GetComponent<AudioSource> ().Play();
	}


    public void OnSpawnBtnClick()
    {
		this.GetComponent<AudioSource> ().clip = doorOpen;
		this.GetComponent<AudioSource> ().Play();
		StartCoroutine (chair ());

        switch (x)
        {
            case 1:
                Instantiate(Liam, new Vector3(0, 0, -1f), Quaternion.identity);
                cueCodeineScript = GameObject.FindGameObjectWithTag("Codeine").GetComponent<Cues>();
                cueCodeineScript.GetScrollView();
                x++;
                break;
            case 2:
                Instantiate(Shane, new Vector3(0, 0, -1f), Quaternion.identity);
                cueDiabetesScript = GameObject.FindGameObjectWithTag("Diabetes").GetComponent<Cues1>();
                cueDiabetesScript.GetScrollView();
                x++;
                break;
            case 3:
                Instantiate(Rodwin, new Vector3(0, 0, -1f), Quaternion.identity);
                cueHealthyScript = GameObject.FindGameObjectWithTag("Healthy").GetComponent<Cues2>();
                cueHealthyScript.GetScrollView();
                x++;
                break;
            case 4:
                Debug.Log("GAME OVER");
                break;
            default:
                break;
        }
        
    }
}

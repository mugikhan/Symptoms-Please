using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour {

	public List<Sprite> sprites = new List<Sprite>();
	public List<AudioClip> sounds = new List<AudioClip>();
	public Sprite idle;
	private float toNext;
	private float fromLast;
	private bool isIdle;
	private int index;

	void Start(){
		isIdle = true;
		index = 0;
		toNext = Random.Range (1f, 3f);
		fromLast = 0f;
	}
		
	void Update () {
		fromLast += Time.deltaTime;
		checkTime ();
	}

	void checkTime(){
		if (fromLast > toNext) {
			isIdle = !isIdle;
			fromLast = 0f;
			if (isIdle) {
				toNext = Random.Range (1f, 5f);
				this.GetComponent<SpriteRenderer> ().sprite = idle;
			} else {
				toNext = 0.3f;
				index = Random.Range (0, sprites.Count);
				this.GetComponent<SpriteRenderer> ().sprite = sprites [index];
				this.GetComponent<AudioSource> ().clip = sounds [index];
				this.GetComponent<AudioSource> ().Play();
			}
		}
	}
}

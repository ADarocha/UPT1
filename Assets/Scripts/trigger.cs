using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour {
	public GameObject brain;
	public AudioClip clip;
	public AudioSource source;
	private int score;
	public Text texte;

	// Use this for initialization
	void Start () {
		source = this.GetComponent<AudioSource> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		texte.text = score.ToString ();
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("collide");
		if (col.gameObject.tag == "cerveau") {
			Debug.Log ("Cerveau Collide");
			this.GetComponentInChildren<Animator>().SetTrigger ("Touche");
			source.clip = clip;
			source.Play ();
			score += 1;
		}
		Destroy (col.gameObject);
	}
}
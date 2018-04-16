using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rate : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	public GameObject joueur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("collide en dehors");
		if (col.gameObject.tag == "cerveau") {
			Debug.Log ("Cerveau Collide en dehors");
			joueur.GetComponentInChildren<Animator>().SetTrigger ("Rate");
			source.clip = clip;
			source.Play ();
		}
		Destroy (col.gameObject);
	}
}

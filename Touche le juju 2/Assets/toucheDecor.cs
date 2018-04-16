using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucheDecor : MonoBehaviour {
	public GameObject brain;
	public AudioClip clip;
	public AudioSource source;
	// Use this for initialization
	void Start () {
		source = this.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("collide");
		source.clip = clip;
		source.Play ();
		col.gameObject.tag = "Finish";

	}
}

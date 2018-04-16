using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancer : MonoBehaviour {

	public GameObject cerveau;
	public int force;
	public int hauteur;
	public int echelleCote;
	public GameObject juju;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}
		float rndX = Random.Range(-0.05f, 0.05f);
		float rndY = Random.Range(-0.04f, 0.04f);

		if(Input.GetMouseButtonDown(0)){
			if (GameObject.Find ("Brain(Clone)") == null) {
				Vector3 p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
				GameObject leCerveau = Instantiate (cerveau, new Vector3 (p.x, p.y, 2.5f), Quaternion.identity);
				//GameObject leCerveau = Instantiate (cerveau, new Vector3(Input.mousePosition.x, Input.mousePosition.y,0), transform.rotation);
				leCerveau.GetComponent<Rigidbody> ().AddForce (p.x * echelleCote, hauteur, force, ForceMode.Impulse);
				rndX += Random.Range (-0.5f, 0.5f);
				rndY += Random.Range (-0.5f, 0.5f);
			}
		}

		if (juju.transform.position.x + rndX >= 0 || juju.transform.position.x + rndX <= -2.4f)
			rndX = 0;
		if (juju.transform.position.y + rndY <= 0 || juju.transform.position.y + rndY >= 0.9f)
			rndY = 0;
		juju.transform.position = new Vector3(juju.transform.position.x+rndX, juju.transform.position.y+rndY, 5);
	}
}

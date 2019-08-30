using UnityEngine;
using System.Collections;

public class TriggerLanding : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter (Collider collider){
		if (collider.tag == "Caja") {
			GameManager.instance.UpdateLanding ();
		}
	}
	void OnTriggerExit (Collider collider){
		if (collider.tag == "Caja") {
			GameManager.instance.NoStay ();
		}
	}

	void Update () {
	
	}
}

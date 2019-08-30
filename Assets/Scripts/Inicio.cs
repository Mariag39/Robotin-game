using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnPlayClick(){
		Application.LoadLevel (1);
	}
	public void OnCreditsClick () {
		Application.LoadLevel (3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

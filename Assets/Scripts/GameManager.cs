using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public int pasos;
	public int pendientes = 0;
	public Text pasosTEXT;
	public Text pendienteTEXT;
	public GameObject Continuar;
	public GameObject Salir;
	public GameObject NivelSuper;
	public GameObject Panel;

	// Use this for initialization
	void Start () {

		pasos = 0;
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		pasosTEXT.text = "Pasos: " + pasos;
		pendienteTEXT.text = "Cajas pendientes: " + pendientes;
		Reset ();

		if (pendientes == 0) {
			Panel.SetActive (true);	
			NivelSuper.SetActive (true);	
			Salir.SetActive (true);	
			Continuar.SetActive (true);

		} 
	}
	public void UpdatePasos () {
		
		pasos += 1;
	}
	public void UpdateLanding () {
		pendientes -= 1;
	}
	public void NoStay() {

		pendientes += 1;


	}


	public void Reset () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel (Application.loadedLevel);
		}

	}

	public void OnContinuarClick() {
		if (Application.loadedLevel == 2) {
			Application.LoadLevel (3);
		}
		if (Application.loadedLevel == 1) {
			Application.LoadLevel (2);
		}
	}


	public void OnSalirClick() {
		Application.LoadLevel (0);
	}
	
	
		
	
	
	
}

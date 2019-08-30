using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int z;
	public int x;
	public int y = 0; 

	void Start () {

	}
	
	void huboColision () {
		RaycastHit hit;
		Vector3 aux = new Vector3(x,y,z);
		if (!Physics.Raycast (transform.position, aux, out hit, 1) || hit.collider.isTrigger) { 
		
			transform.Translate (aux);
			GameManager.instance.UpdatePasos ();
		}

			
		else {
			hit.collider.GetComponent<Pushable>();
		
			Pushable pushable = hit.collider.GetComponent<Pushable>(); 
			if(pushable != null){
			
				if (pushable.push (x, z)) {
			    transform.Translate (aux);
				GameManager.instance.UpdatePasos ();
				}
				}
				
			}
	}
			


	// Update is called once per frame
	void Update () {
		z = 0;
		x = 0;
		y = 0;

		if (Input.GetKeyDown (KeyCode.W)) {
			z += 1;
		
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			z -= 1;
	

		}
		if (Input.GetKeyDown (KeyCode.A)) {
			x -= 1;


		}
		
		if (Input.GetKeyDown (KeyCode.D)) {
			x += 1;

		
		}
	
			if (x != 0 || z != 0) {
			huboColision ();
		}
		}
}

using UnityEngine;
using System.Collections;

public class Pushable : MonoBehaviour {


  public bool push (int x, int z){

	Vector3 vec = new Vector3(x,0,z);
		RaycastHit hit;
		if (!Physics.Raycast (transform.position, vec, out hit, 1) || hit.collider.isTrigger) { 
			transform.position += (vec);
			return true;


		}else {
			return false;
		}
	

	}

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}

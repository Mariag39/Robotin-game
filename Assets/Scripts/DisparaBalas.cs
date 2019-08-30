using UnityEngine;
using System.Collections;

public class DisparaBalas : MonoBehaviour {

    public GameObject bala;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject nuevo = GameObject.Instantiate(bala);
            nuevo.transform.position = new Vector3(
                transform.position.x + 1,
                transform.position.y + 1, 0);

            //nuevo.GetComponent<DisparaBalas>().enabled = false;
        }
	}
}

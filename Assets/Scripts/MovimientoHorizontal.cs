using UnityEngine;
using System.Collections;

public class MovimientoHorizontal : MonoBehaviour {

    public int topeIzdo = -6;
    public int topeDcho = 6;

    public GameObject paredDerecha;
    public GameObject paredIzquierda;

    public UnityEngine.UI.Text texto;

    float incrX = 0.1f;

	// Update is called once per frame
	void Update () {

        if (transform.position.x + incrX >= topeDcho)
            incrX = -incrX;
        else if (transform.position.x + incrX <= topeIzdo)
            incrX = -incrX;

        transform.Translate(new Vector3(incrX, 0, 0));
        paredIzquierda.SetActive(incrX < 0);
        paredDerecha.SetActive(incrX > 0);

        texto.text = "" + incrX;
    }
}

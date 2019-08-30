using UnityEngine;
using System.Collections;

public class MovimientoVertical : MonoBehaviour {

    public int topeArriba = 4;
    public int topeAbajo = -4;

    public GameObject paredSuperior;
    public GameObject paredInferior;

    float incrY = 0.1f;

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y + incrY >= topeArriba)
            incrY = -incrY;
        else if (transform.position.y + incrY <= topeAbajo)
            incrY = -incrY;

        transform.Translate(new Vector3(0, incrY, 0));

        /*
        if (incrY > 0)
        {
            paredInferior.SetActive(false);
            paredSuperior.SetActive(true);
        } else if (incrY < 0)
        {
            paredInferior.SetActive(true);
            paredSuperior.SetActive(false);
        }
        */

        paredInferior.SetActive(incrY < 0);
        paredSuperior.SetActive(incrY > 0);
    }
}

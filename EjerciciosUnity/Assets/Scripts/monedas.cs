using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour {

    static int amarillas = 0;

    void OnTriggerEnter2D(Collider2D quienTraspasa)
    {
        //mostramos por consola el nombre de quien ha entrado en el collider tipo trigger
        Debug.Log(quienTraspasa.gameObject.name);

        if (quienTraspasa.gameObject.tag == "Player")
        {
            amarillas++;
            Debug.Log("Monedas Amarillas: " + amarillas);
            Destroy(gameObject);
        }
    }

}
	//de esta forma tenemos el contador en las monedas, pero también se puede poner en el personaje
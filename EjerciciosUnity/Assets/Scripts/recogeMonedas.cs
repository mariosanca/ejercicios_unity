using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogeMonedas : MonoBehaviour {

    public int monedas = 0;

    void OnTriggerEnter2D(Collider2D aQuienTraspaso)
    {
        if (aQuienTraspaso.gameObject.CompareTag("Moneda"))
        {
            monedas++;
            Destroy (aQuienTraspaso.gameObject);
        }
    }
}
//de esta forma el personaje sería el monedero, pero también se puede poner el contador en las propias monedas
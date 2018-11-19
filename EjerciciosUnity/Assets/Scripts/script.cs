using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

	Rigidbody2D miCuerpaso;

	public float fuerza = 10;
	public float velocidadMaxima = 5;
	public float fuerzaSalto = 300;
    public bool miraDerecha = true;

    Animator animacion;

	// Use this for initialization
	void Start () {
		miCuerpaso = GetComponent<Rigidbody2D> ();
		animacion = GetComponent<Animator> ();

		//miRitmo.SetFloat ();
		//miRitmo.SetBool ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow))
        {
            MueveIzquierda();
		}

		if (Input.GetKey (KeyCode.RightArrow))
        {
            MueveDerecha();
		}
		
		if (Input.GetKeyDown (KeyCode.Space))
        {
			miCuerpaso.AddForce(Vector2.up * fuerzaSalto);
		}

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animacion.SetBool("agachado", true);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animacion.SetBool("agachado", false);
        }

        animacion.SetFloat("velocidad", Mathf.Abs(miCuerpaso.velocity.x));
	}
    



    void GiraSprite ()
    {
        miraDerecha = !miraDerecha;
        transform.Rotate(0f, 180f, 0f);
    }

    void Salto ()
    {

    }

    void MueveIzquierda()
    {
        if (miCuerpaso.velocity.x > -velocidadMaxima)
        {
            miCuerpaso.AddForce(Vector2.left * fuerza);
        }    

        if (miraDerecha)
        {
            GiraSprite();
        }
    }

    void MueveDerecha()
    {
        if (miCuerpaso.velocity.x < velocidadMaxima)
        {
            miCuerpaso.AddForce(Vector2.right * fuerza);
        }

        if (!miraDerecha)
        {
            GiraSprite();
        }
    }

}



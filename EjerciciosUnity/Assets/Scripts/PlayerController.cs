using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D player;

    float fuerza = 10;

    Vector2 mousePosition;


	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        mueveTeclas();

        sigueRaton();

        //sigueClicks();

	}

    void mueveTeclas() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        player.velocity = new Vector2(h, v) * fuerza;
    }

    void sigueRaton() 
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 posicion = new Vector2(mousePosition.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, posicion, fuerza * Time.deltaTime);
    }

    /*void sigueClicks () 
    {
        if (Input.GetMouseButton(0))
        {
            sigueRaton();
        }
    }*/
}

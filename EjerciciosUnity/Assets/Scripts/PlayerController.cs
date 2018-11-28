using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    //Cosas para mover al player
    Rigidbody2D player;
    float fuerza = 10f;

    Transform posicionPlayer;
    Vector2 mousePosition;
    Vector2 posicionClick;

    //Cosas para atraer los imanes
    Rigidbody2D rbIman;
    Transform trIman;


    bool dentro;
    
    float radio = 5f;

	// Use this for initialization
	void Start () {

        player = GetComponent<Rigidbody2D>();

        posicionPlayer = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        //mueveTeclas();

        //sigueRaton();

        sigueClicks();

    }

    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "magnetico")
        {
            rbIman = col.gameObject.GetComponent<Rigidbody2D>();
            rbIman.simulated = false;

            trIman = col.gameObject.GetComponent<Transform>();
            trIman.parent = transform;


        }
    }



    void mueveTeclas()
    {
        float h = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(h * fuerza, player.velocity.y);
    }


    void sigueRaton()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0;
        posicionPlayer.position = mousePosition;
    }


    void sigueClicks()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionClick = mousePosition;
        }

        Vector2 posicion = new Vector2(mousePosition.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, posicion, fuerza * Time.deltaTime);

    }


}


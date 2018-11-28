using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D player;

    float fuerza = 10;

    Vector2 mousePosition;

    Vector2 posicionClick;

    bool dentro;
    Transform magnet;
    float radio = 5f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();

     
	}
	
	// Update is called once per frame
	void Update () {

        //mueveTeclas();

        //sigueRaton();

        sigueClicks();

    }

    void mueveTeclas() 
    {
        float h = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(h, 0) * fuerza;
    }

    void sigueRaton() 
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 posicion = new Vector2(mousePosition.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, posicion, fuerza * Time.deltaTime);
    }

    void sigueClicks () 
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionClick = mousePosition;
        }

        Vector2 posicion = new Vector2(mousePosition.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, posicion, fuerza * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "magnetico")
        {
            cogeMagnet(col.transform);
        }
    }

    void cogeMagnet (Transform trMagnet)
    {
        trMagnet.parent = transform;

        trMagnet.GetComponent<Rigidbody2D>();
        
    }

}


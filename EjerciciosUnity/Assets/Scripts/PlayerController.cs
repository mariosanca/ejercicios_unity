using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    //Cosas para mover al player
    Rigidbody2D player;
    float fuerza = 10f;

    Transform posicionPlayer;
    Vector2 mousePosition;
    Vector2 posicionClick;

    //Cosas para atraer los imanes

    Transform trIman;
    public List<GameObject> imanes;

    //Cosas para la UIIIIIII

    public Text textoImanes;

	// Use this for initialization
	void Start () {

        player = GetComponent<Rigidbody2D>();

        posicionPlayer = GetComponent<Transform>();

        textoImanes.text = imanes.Count.ToString();
	}
	
	// Update is called once per frame
	void Update () {

        MueveTeclas();

        //SigueRaton();

        //SigueClicks();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }

    }

    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "magnetico")
        {
            Rigidbody2D rbIman = col.gameObject.GetComponent<Rigidbody2D>();
            rbIman.simulated = false;

            trIman = col.gameObject.GetComponent<Transform>();
            trIman.parent = transform;

            
            GameObject nuevoIman = col.gameObject;
            imanes.Add(nuevoIman);

            textoImanes.text = imanes.Count.ToString();
            
        }
    }



    void MueveTeclas()
    {
        float h = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(h * fuerza, player.velocity.y);
    }


    void SigueRaton()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0;
        posicionPlayer.position = mousePosition;
    }


    void SigueClicks()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionClick = mousePosition;
        }

        Vector2 posicion = new Vector2(mousePosition.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, posicion, fuerza * Time.deltaTime);

    }

    void Disparar()
    {
        if (imanes.Count > 0)
        {
            Rigidbody2D rbImanes = imanes[imanes.Count - 1].GetComponent<Rigidbody2D>();
            imanes[imanes.Count - 1].transform.parent = null;
            rbImanes.simulated = true;
            rbImanes.velocity = Vector2.right * fuerza;
            imanes.Remove(imanes[imanes.Count - 1]);

            textoImanes.text = imanes.Count.ToString();
        }
    }

}


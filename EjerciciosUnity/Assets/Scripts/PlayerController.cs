using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D player;

    float fuerza = 10;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        player.velocity = new Vector2(h, v) * fuerza;



	}
}

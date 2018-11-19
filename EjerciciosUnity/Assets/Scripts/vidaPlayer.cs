using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaPlayer : MonoBehaviour {

    public int vida = 5;

    void OnCollisionStay2D(Collision2D vidaTengo)
    {
        

        if (vidaTengo.gameObject.CompareTag("enemigo"))
        {
            vida--;
        }
        

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
        


        
    }
}

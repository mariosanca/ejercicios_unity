using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Animator anim;
    public bool pausa;

	// Use this for initialization
	/*void Start () {

        pausa = true;
    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            anim.SetBool("activar", pausa);
        }

        if (pausa)
        {
            Time.timeScale = 0f;
        }

        else { Time.timeScale = 1f; }

	}

    public void PulsoPaly()
    {
        Time.timeScale = 1f;
        pausa = !pausa;
        anim.SetBool("activar", !pausa);
        SceneManager.LoadScene("Escena1");
        
    }
    */
}

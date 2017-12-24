using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Vkl_pitanie : MonoBehaviour {
    public Animator ON;
    private bool b = true;
    public TextMesh lol;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (b)
        {
            ON.SetBool("Vkl_pitanie_on", b);
            ON.SetBool("Vkl_pitanie_off", !b);
            lol.text = "0000";

        }
        if (!b)
        {
            ON.SetBool("Vkl_pitanie_off", !b);
            ON.SetBool("Vkl_pitanie_on", b);
            lol.text = "";

        }


        b = !b;

    }

    // Update is called once per frame
    void FixedUpdate () {
        if (b)
        {
            //Izmer.Napryazhenie;
            lol.text = "";
        }
		
	}
}

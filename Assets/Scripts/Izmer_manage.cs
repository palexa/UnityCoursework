using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izmer_manage : MonoBehaviour {
    public Animator Izmer;
    private bool b = true;
    //public TextMesh lol;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (b)
        {
            Izmer.SetBool("Izmer_on", b);
            Izmer.SetBool("Izmer_off", !b);
            //lol.text = "0000";
        }
        if (!b)
        {
            Izmer.SetBool("Izmer_off", !b);
            Izmer.SetBool("Izmer_on", b);
            //lol.text = "";
        }


        b = !b;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

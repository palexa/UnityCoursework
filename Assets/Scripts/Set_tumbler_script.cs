using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_tumbler_script : MonoBehaviour {

    public Animator ON;
    private bool b = true;
    public Light light;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (b)
        {
            ON.SetBool("Set_tumbler_on", b);
            ON.SetBool("Set_tumbler_off", !b);
            light.enabled = true;

        }
        if (!b)
        {
            ON.SetBool("Set_tumbler_off", !b);
            ON.SetBool("Set_tumbler_on", b);
            light.enabled = false;

        }


        b = !b;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

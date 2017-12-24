using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class PITmanage : MonoBehaviour {

    public Animator PIT;
    private bool b = true;
    private bool ison ;
    public TextMesh lol;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (b)
        {
            PIT.SetBool("PITon", b);
            PIT.SetBool("PIToff", !b);
            lol.text = "0000";
            ison = true;
        }
        if (!b)
        {
            PIT.SetBool("PIToff", !b);
            PIT.SetBool("PITon", b);
            lol.text = "";
            ison = false;
        }


        b = !b;

    }

    // Update is called once per frame
    void FixedUpdate () {
        if (ison)
        {
           
            lol.text = "000"+Izmer.Napryazhenie.ToString();
        }

    }
}

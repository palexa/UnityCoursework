using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumbler1_manage : MonoBehaviour {
    
    public Animator Tumbler1;
    private bool b = true;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (b)
        {
            Tumbler1.SetBool("Tumbler1_on", b);
            Tumbler1.SetBool("Tumbler1_off", !b);
        }
        if (!b)
        {
            Tumbler1.SetBool("Tumbler1_off", !b);
            Tumbler1.SetBool("Tumbler1_on", b);
            
        }


        b = !b;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

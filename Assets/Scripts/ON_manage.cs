using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class ON_manage : MonoBehaviour {

    public Animator ON;
    private bool b = true;
    public Light light;// = new Light();
    public Light set;
    public Text helpText;

    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (set.isActiveAndEnabled == true)
        {
            if (b)
            {
                ON.SetBool("ON", b);
                ON.SetBool("OFF", !b);
                Izmer.PITisOn = true;
                light.enabled = true;

                //Izmer.isOn = true;
            }
            if (!b)
            {
                ON.SetBool("OFF", !b);
                ON.SetBool("ON", b);
                light.enabled = false;
                

            }


            b = !b;
        }
        else
        {
            helpText.text = "Включите сеть сначала";
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {

    public Camera camera;
    // Use this for initialization
    void Start () {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
           
            // Do something with the object that was hit by the raycast.
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

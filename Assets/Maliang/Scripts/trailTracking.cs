using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailTracking : MonoBehaviour {
    public GameObject controller;
    public GameObject trailSource;
        // Use this for initialization
    private bool isDownflag = false;
	void Start () {

        


    }
	
	// Update is called once per frame
	void Update () {
        //isDownflag = controller.GetComponent<ControllerGrabObject>().isDown;



        //if (isDownflag)
        //{
        //    gameObject.transform.position = trailSource.transform.position;
        //}
        //else
        //{

        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDrawing : MonoBehaviour {
    public Transform trail;
    //public GameObject controller;
    public GameObject effectManager;

    private ControllerGrabObject rightHnadGrab;
    private Transform createdTrail;
        //public GameObject trailSource;
    // Use this for initialization
    private bool isDownflag = false;

    void Awake()
    {
       rightHnadGrab = GameObject.FindGameObjectWithTag("RighthandController").GetComponent<ControllerGrabObject>();
    }

    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        if (rightHnadGrab.isDown)
        {
            if(!gameObject.GetComponent<AudioSource>().isPlaying)
            gameObject.GetComponent<AudioSource>().PlayScheduled(0.1);
            if (!isDownflag)
            {
                createdTrail = Instantiate(trail, gameObject.transform.position, Quaternion.identity, gameObject.transform);
                isDownflag = rightHnadGrab.isDown;
            }
        }

        if (!rightHnadGrab.isDown)
        {
            gameObject.GetComponent<AudioSource>().Stop();
            if (isDownflag)
            {
                //Instantiate(trail, new Vector3(x, y, 0), Quaternion.identity);
                Debug.Log("song");
                createdTrail.SetParent(effectManager.transform);
                isDownflag = rightHnadGrab.isDown;
            }
        }
            



       
    }


}

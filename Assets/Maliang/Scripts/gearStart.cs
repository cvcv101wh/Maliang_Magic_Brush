using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearStart : MonoBehaviour {
    public GameObject thebigGear;
    /// <summary>
    
    /// </summary>
    
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Animator>().SetBool("LoopingLeft",true);
        thebigGear.GetComponent<Animator>().SetBool("LoopingSlow", true);
        /// ///////// open the hidden door
        GameObject.Find("Moveable_wall1").GetComponent<openTheDoor>().openTheDoorFlag = true;
        GameObject.Find("Moveable_wall1").GetComponent<AudioSource>().Play();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

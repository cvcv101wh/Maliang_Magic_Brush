using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villain : MonoBehaviour {

    private Vector3 frontDoor = new Vector3(0.201f, -0.03f, 2.761f);


    public bool theDoorIsClosed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    if((transform.position.x > frontDoor.x) & (transform.position.z < frontDoor.z))
        {
            if (theDoorIsClosed)
            {
                transform.position = frontDoor;
                gameObject.GetComponent<Animator>().SetBool("Run", false);
            }
            else
            {
                Debug.Log("Lose");
                transform.position = frontDoor;
                gameObject.GetComponent<Animator>().SetBool("Run", false);
            }
        }
		
	}
}
